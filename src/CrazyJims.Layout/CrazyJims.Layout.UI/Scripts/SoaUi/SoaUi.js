/// <reference path="../jquery-1.4.1.js"/>
/// <reference path="../underscore.js"/>

// Object Extensions ----------------------------------------------------------

Object.prototype.clone = function () {
    var newObj = (this instanceof Array) ? [] : {};
    for (i in this) {
        if (i == 'clone') continue;
        if (this[i] && typeof this[i] == "object") {
            newObj[i] = this[i].clone();
        } else newObj[i] = this[i]
    } return newObj;
};

// Array Extensions -----------------------------------------------------------

multipleMatchException = new Error("Cannot get matching item when multiple matches exist");

Array.prototype.getMatchingItemOrPlaceholderItemById = function (key) {
    var matchingValueDataItems = _.select(this, function (valueDataItem) {
        return valueDataItem.Id == key;
    });

    if (matchingValueDataItems.length > 1)
        throw multipleMatchException;

    if (matchingValueDataItems.length == 0) {
        var copiedObject = this[0].clone();
        for (property in copiedObject) {
            var something = property;
            if (property == "Id")
                copiedObject[property] = key;
            else
                copiedObject[property] = "Not Available";
        }

        return copiedObject;
    }

    return matchingValueDataItems[0];
}

// SoaUi ----------------------------------------------------------------------

var SoaUi = new Object();

// Data Matching

SoaUi.matchColumns = function (keyColumn, nextColumn) {

    var matchedColumns = new Array();

    for (keyColumnIndex in keyColumn) {
        var memberType = typeof (keyColumn[keyColumnIndex])
        if (memberType == "object") {
            var matchingNextColumnItem = nextColumn.getMatchingItemOrPlaceholderItemById(keyColumn[keyColumnIndex].Id);
            matchedColumns.push(matchingNextColumnItem);
        }
    }

    return matchedColumns;
}

// Data Composition

SoaUi.composeData = function (keyData, valueData) {
    var composedData = _.map(keyData, function (keyDataItem) {
        var matchingValueDataItem = valueData.getMatchingItemOrPlaceholderItemById(keyDataItem.Id);

        var newItem = _.extend(keyDataItem, matchingValueDataItem);

        return newItem;

    });

    return composedData;
}
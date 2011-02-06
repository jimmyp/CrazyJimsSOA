<%@ Page Title="" Language="C#" Inherits="CrazyJims.Layout.UI.Common.CompositeViewPage" MasterPageFile="~/Views/Shared/CrazyJims.Master" %>
<asp:Content runat="server" ID="TitleContent" ContentPlaceHolderID="titleContent"></asp:Content>
<asp:Content runat="server" ID="HeadContent" ContentPlaceHolderID="headContent">
    <link rel="Stylesheet" href="<%= Url.Content("~/Content/Index.css") %>" />

    <script src="<%= Url.Content ("~/Scripts/jquery-1.4.1.js") %>" type="text/javascript" ></script>
    <script src="<%= Url.Content ("~/Scripts/jTemplates/jquery-jtemplates_uncompressed.js") %>" type="text/javascript"></script>
    <script src="<%= Url.Content ("~/Scripts/underscore.js") %>" type="text/javascript"></script>
    <script src="<%= Url.Content ("~/Scripts/SoaUi/SoaUi.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        /// <reference path="../../Scripts/jquery-1.4.1.js"/>
        /// <reference path="../../Scripts/underscore.js"/>
        
        var catalougeProductNamesTemplateUrl = '<%=GetTemplatePath("ProductService", "CatalougeProducts") %>';
        var catalougeProductNamesDataUrl = 'http://localhost/Products/GetAll';

        var catalougeProductPricesTemplateUrl = '<%=GetTemplatePath("PricingService", "CatalougePricing") %>';
        var catalougeProductPricesDataUrl = 'http://localhost/Pricing/GetAll';

        var catalougePlaceOrderTemplateUrl = '<%=GetTemplatePath("OrderService", "PlaceOrder") %>';
        var catalougePlaceOrderDataUrl = 'http://localhost/Orders/PlaceOrder';
        
        $(document).ready(function () {
            $("#productNames").setTemplateURL(catalougeProductNamesTemplateUrl);
            var keyColumnData;
            $.ajax({
                url: catalougeProductNamesDataUrl,
                dataType: "json",
                success: function (data) {
                    keyColumnData = data;
                    $("#productNames").processTemplate(keyColumnData);
                }
            });

            $("#productPrices").setTemplateURL(catalougeProductPricesTemplateUrl);
            $.ajax({
                url: catalougeProductPricesDataUrl,
                dataType: "json",
                success: function (data) {
                    var orderedData = SoaUi.matchColumns(keyColumnData, data);
                    $("#productPrices").processTemplate(orderedData);
                }
            });

            $("#placeOrder").setTemplateURL(catalougePlaceOrderTemplateUrl);
            $.ajax({
                url: catalougePlaceOrderDataUrl,
                dataType: "json",
                success: function (data) {
                    var orderedData = SoaUi.matchColumns(keyColumnData, data);
                    $("#productPrices").processTemplate(orderedData);
                }
            });
        });
    </script>
</asp:Content>
<asp:Content runat="server" ID="MainContent" ContentPlaceHolderID="mainContent">
    <h2>Catalouge</h2>
    <div id="productNames"></div>
    <div id="productPrices"></div>
    <div id="placeOrder"></div>  
</asp:Content>

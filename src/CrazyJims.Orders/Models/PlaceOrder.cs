using System;
using CrazyJims.Common;

namespace CrazyJims.Orders.Models
{
    public class PlaceOrder : CompositeTableColumn
    {
        public bool CanPlaceOrder { get; private set; }
        public string ActionUri { get; private set; }

        public PlaceOrder(Guid id, bool canOrder, Uri actionUri) : base(id)
        {
            Guard.AgainstNullArguments(canOrder, "canOrder");
            CanPlaceOrder = canOrder;

            Guard.AgainstNullArguments(actionUri, "actionUri");
            ActionUri = actionUri.ToString();
        }
    }
}
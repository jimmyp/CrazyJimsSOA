using System;
using CrazyJims.Common;

namespace CrazyJims.Orders.Models
{
    public class PlaceOrder
    {
        public Guid Guid { get; set; }
        public bool CanPlaceOrder { get; set; }

        private PlaceOrder()
        {
            
        }
        public PlaceOrder(Guid guid, bool canOrder)
        {
            Guard.AgainstNullArguments(guid, "guid");
            Guid = guid;

            Guard.AgainstNullArguments(canOrder, "canOrder");
            CanPlaceOrder = canOrder;
        }
    }
}
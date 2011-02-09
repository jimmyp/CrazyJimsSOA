using System;
using CrazyJims.Common;

namespace CrazyJims.Pricing.UI.Models
{
    public class ProductPrice : CompositeTableColumn
    {
        public decimal Price { get; private set; }

        public ProductPrice(Guid id, Money value) : base(id)
        {
            Guard.AgainstNullArguments(value, "value");
            Price = value.Price;
        }
    }
}
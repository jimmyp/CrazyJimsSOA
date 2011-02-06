using System;
using CrazyJims.Common;

namespace CrazyJims.Pricing.UI.Models
{
    public class ProductPrice
    {
        public Guid Id { get; private set; }
        public decimal Price { get; private set; }

        public ProductPrice(Guid id, Money value)
        {
            Guard.AgainstNullArguments(id, "id");
            Id = id;

            Guard.AgainstNullArguments(value, "value");
            Price = value.Price;
        }
    }
}
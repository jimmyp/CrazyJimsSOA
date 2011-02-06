using CrazyJims.Common;

namespace CrazyJims.Pricing.UI.Models
{
    public class Money
    {
        public decimal Price { get; private set; }

        public Money(decimal price)
        {
            Guard.AgainstNullArguments(price, "price");
            Price = price;
        }
    }
}
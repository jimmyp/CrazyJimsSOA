using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrazyJims.Common;

namespace CrazyJims.Products.UI.Models
{
    public class Product
    {
        private Product()
        {
            
        }

        public Product(Guid id, string name)
        {
            Guard.AgainstNullArguments(id, "id");
            Id = id;

            Guard.AgainstNullArguments(name, "name");
            Name = name;
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; }
    }
}
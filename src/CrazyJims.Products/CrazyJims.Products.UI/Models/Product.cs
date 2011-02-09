using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrazyJims.Common;

namespace CrazyJims.Products.UI.Models
{
    public class Product : CompositeTableColumn
    {
        public Product(Guid id, string name) : base(id)
        {
            Guard.AgainstNullArguments(name, "name");
            Name = name;
        }

        public string Name { get; private set; }
    }
}
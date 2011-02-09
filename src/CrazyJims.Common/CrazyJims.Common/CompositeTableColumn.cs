using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrazyJims.Common
{

    public class CompositeTableColumn
    {
        private CompositeTableColumn()
        {
            
        }

        protected CompositeTableColumn(Guid id)
        {
            Guard.AgainstNullArguments(id, "guid");
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrazyJims.Common;

namespace CrazyJims.Products.UI.Controllers
{
    //Todo : this needs to move to common
    public abstract class TemplateController : TemplateBaseController
    {
        public TemplateController(ITemplateRepository templateRepository)
            :base (templateRepository)
        {
        }
    }
}

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
    public class TemplateController : Controller
    {
        public TemplateController(ITemplateRepository templateRepository)
        {
            Guard.AgainstNullArguments(templateRepository, "templateRepository");
            TemplateRepository = templateRepository;
        }

        protected ITemplateRepository TemplateRepository { get; set; }

        [HttpGet]
        public ContentResult GetTemplate(string templateName)
        {
            var template = TemplateRepository.Get(templateName);
            return Content(template);
        }
    }
}

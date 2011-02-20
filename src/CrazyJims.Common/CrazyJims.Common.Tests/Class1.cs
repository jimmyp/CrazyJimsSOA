using System;
using CrazyJims.Common;
using CrazyJims.Products.UI.Controllers;
using NSubstitute;
using NUnit.Framework;

namespace CrazyJims.Products.UI.Tests
{
    [TestFixture]
    public class TemplateControllerTests
    {
        [Test]
        public void GetTemplate_Should_Return_Content_From_Template_Repository()
        {
            //Setup
            const string someTemplate = "I am some template text";

            var templateRepository = Substitute.For<ITemplateRepository>();
            templateRepository.Get("SomeTemplate").Returns(someTemplate);

            var templateController = new TemplateController(templateRepository);

            //Act
            var result = templateController.GetTemplate("SomeTemplate");

            //Test
            Assert.AreEqual(someTemplate, result.Content);
        }
    }

    public class TemplateController : TemplateBaseController
    {
        public TemplateController(ITemplateRepository templateRepository)
            :base(templateRepository)
        {
                
        }
    }
}

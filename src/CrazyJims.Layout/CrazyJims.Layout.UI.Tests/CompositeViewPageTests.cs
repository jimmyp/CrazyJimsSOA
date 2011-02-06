using CrazyJims.Layout.UI.Common;
using NSubstitute;
using NUnit.Framework;

namespace CrazyJims.Layout.UI.Tests
{
    [TestFixture]
    public class CompositeViewPageTests
    {
        [Test]
        public void GetTemplatePath_Returns_Path_Using_AppSettings_And_Convention()
        {
            //Setup
            var settingsManager = Substitute.For<ISettingsManager>();
            settingsManager.GetValue("SomeServiceUrl").Returns("http://SomeHost/SomeService");
            var compositeViewPage = new CompositeViewPage(settingsManager);

            //Act
            var result = compositeViewPage.GetTemplatePath("SomeService", "SomeTemplate");

            //Test
            Assert.AreEqual("http://SomeHost/SomeService/Template/SomeTemplate", result);
        }
    }
}

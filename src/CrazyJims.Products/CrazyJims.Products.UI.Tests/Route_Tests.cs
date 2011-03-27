using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web;
using System.Web.Routing;
using CrazyJims.Products.UI;
using NSubstitute;
using NUnit.Framework;

namespace CrazyJims.Layout.UI.Tests
{
    [TestFixture]
    public class Route_Tests
    {
        [Test]
        public void Template_Controller_Maps_According_To_Convention()
        {
            RouteCollection routes = new RouteCollection();
            MvcApplication.RegisterRoutes(routes);

            TestHelper.AssertRoute(routes, "~/Template/SomeTemplate",
                                   new {controller = "Template", action = "GetTemplate", templateName = "SomeTemplate"});
        }
    }

    //Todo: To common testing assembly
    public class TestHelper
    {
        public static void AssertRoute(RouteCollection routes, string url, object expectations)
        {
            var httpRequestBase = Substitute.For<HttpRequestBase>();
            httpRequestBase.AppRelativeCurrentExecutionFilePath.Returns(url);

            var httpContextMock = Substitute.For<HttpContextBase>();
            httpContextMock.Request.Returns(httpRequestBase);

            RouteData routeData = routes.GetRouteData(httpContextMock);
            Assert.IsNotNull(routeData, "Should have found the route");

            foreach (PropertyValue property in GetProperties(expectations))
            {
                Assert.IsTrue(  string.Equals(property.Value.ToString(), routeData.Values[property.Name].ToString(),StringComparison.OrdinalIgnoreCase), 
                                string.Format("Expected '{0}', not '{1}' for '{2}'.", property.Value, routeData.Values[property.Name], property.Name));
            }
        }

        private static IEnumerable<PropertyValue> GetProperties(object o)
        {
            if (o != null)
            {
                PropertyDescriptorCollection props = TypeDescriptor.GetProperties(o);
                foreach (PropertyDescriptor prop in props)
                {
                    object val = prop.GetValue(o);
                    if (val != null)
                    {
                        yield return new PropertyValue { Name = prop.Name, Value = val };
                    }
                }
            }
        }

        private sealed class PropertyValue
        {
            public string Name { get; set; }
            public object Value { get; set; }
        }
    }
}

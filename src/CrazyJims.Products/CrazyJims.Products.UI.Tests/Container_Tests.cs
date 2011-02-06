using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using StructureMap;

namespace CrazyJims.Products.UI.Tests
{
    [TestFixture]
    public class Container_Tests
    {
        [Test]
        public void Container_Config_Should_Be_Valid()
        {
            //Setup
            ContainerConfig.Configure();

            //Act & Test
            ObjectFactory.AssertConfigurationIsValid();
        }

    }
}

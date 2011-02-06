using System.Web.Mvc;
using StructureMap;

namespace CrazyJims.Common
{
    public class ControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, System.Type controllerType)
        {
            var controller = ObjectFactory.GetNamedInstance<IController>(controllerType.Name) ??
                             base.GetControllerInstance(requestContext, controllerType);

            return controller;
        }
    }

}
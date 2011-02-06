using System.Web.Mvc;
using CrazyJims.Common;
using StructureMap;

namespace CrazyJims.Products.UI
{
    public static class ContainerConfig
    {
        public static void Configure()
        {
            ObjectFactory.Initialize(c =>
                                         {
                                             c.Scan(s =>
                                                        {
                                                            s.TheCallingAssembly();
                                                            s.AddAllTypesOf<IController>().NameBy(type => type.Name);
                                                        });
                                                         
                                               c.For<ITemplateRepository>().HttpContextScoped().Use<TemplateRepository>();
                                          });
            
            ObjectFactory.WhatDoIHave();
        }
    }
}
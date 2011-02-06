using System;
using System.Web.Mvc;
using CrazyJims.Common;

namespace CrazyJims.Layout.UI.Common
{
    //ToDo: Figure a way of injecting a settings manager in here without resorting to service location, for now poor mans DI will do
    public class CompositeViewPage : ViewPage
    {
        public CompositeViewPage()
        {
            SettingsManager = new SettingsManager();
        }

        public CompositeViewPage(ISettingsManager settingsManager)
        {
            Guard.AgainstNullArguments(settingsManager, "settingsManager");
            SettingsManager = settingsManager;
        }

        protected ISettingsManager SettingsManager { get; set; }

        public string GetTemplatePath(string serviceName, string templateName)
        {
            var servicePath = SettingsManager.GetValue(serviceName + "Url");
            var templatePath = String.Format("{0}/Template/{1}", servicePath, templateName);
            return templatePath;
        }
    }
}
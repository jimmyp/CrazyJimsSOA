using System.Configuration;

namespace CrazyJims.Layout.UI.Common
{
    public class SettingsManager : ISettingsManager
    {
        public string GetValue(string key)
        {
            return ConfigurationManager.AppSettings.Get(key);
        }
    }
}
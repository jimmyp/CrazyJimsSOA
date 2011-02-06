using System.IO;
using System.Web;

namespace CrazyJims.Common
{
    public class TemplateRepository : ITemplateRepository
    {
        public string Get(string id)
        {
            var dir = HttpContext.Current.Server.MapPath("~/Content/Templates");
            var path = Path.Combine(dir, id + ".tpl");
            string fileContents;

            using (var fileStream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    fileContents = streamReader.ReadToEnd();
                }
            }

            return fileContents;
        }
    }
}
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace Ticy.Web
{
    public class ResultFormatConfig
    {
        public static void SetJson(HttpConfiguration config)
        {
            MediaTypeFormatterCollection formatters = config.Formatters;

            formatters.XmlFormatter.SupportedMediaTypes.Remove(
                formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml")
            );

            var settings = formatters.JsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
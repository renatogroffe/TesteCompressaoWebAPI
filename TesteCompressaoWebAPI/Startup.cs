using Owin;
using System.Web.Http;
using Microsoft.AspNet.WebApi.MessageHandlers.Compression;
using Microsoft.AspNet.WebApi.MessageHandlers.Compression.Compressors;

namespace TesteCompressaoWebAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            HttpConfiguration config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "testes/{controller}"
            );

            config.Formatters.Remove(
                config.Formatters.XmlFormatter);

            config.MessageHandlers.Insert(0,
                new ServerCompressionHandler(
                    new GZipCompressor(),
                    new DeflateCompressor())); 
            
            appBuilder.UseWebApi(config);
        } 
    }
}
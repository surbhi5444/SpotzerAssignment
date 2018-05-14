using System.Web.Http;
using WebActivatorEx;
using SpotzerOrderApi;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace SpotzerOrderApi
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {

                        c.SingleApiVersion("v1", "SpotzerOrderApi");


                    })
                .EnableSwaggerUi(c =>
                    {

                    });
        }
    }
}

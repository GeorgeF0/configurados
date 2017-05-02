using Configurados.Configuration;
using Configurados.Store;
using Nancy;
using Nancy.Extensions;

namespace Configurados
{
    public class Api : NancyModule
    {
        public Api(IConfiguration configuration, IStore store)
        {
            Get["/config"] = _ =>
            {
                var key = Request.Query["key"];
                return key == null ? HttpStatusCode.BadRequest : configuration[Request.Query["key"]];
            };

            Post["/config"] = _ =>
            {
                var author = Request.Query["author"];
                if (author == null) return HttpStatusCode.Unauthorized;

                var key = Request.Query["key"];
                if (key == null) return HttpStatusCode.BadRequest;

                var value = Request.Body.AsString();

                configuration[key] = value;
                store.Save(new ConfigUpdate{Author = author, Key = key, Value = value});

                return HttpStatusCode.OK;
            };
        }
    }
}

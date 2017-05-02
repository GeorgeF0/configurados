using System;
using Configurados.Configuration;
using Configurados.Store;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.TinyIoc;

namespace Configurados.Nancy
{
    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ApplicationStartup(TinyIoCContainer container, IPipelines pipelines)
        {
            base.ApplicationStartup(container, pipelines);

            var store = container.Resolve<IStore>();
            var configuration = container.Resolve<IConfiguration>();

            var saved = store.Load();

            Console.WriteLine("Loading configuration...");

            foreach (var update in saved)
            {
                configuration[update.Key] = update.Value;
            }

            Console.WriteLine("Loading complete!");
        }
    }
}

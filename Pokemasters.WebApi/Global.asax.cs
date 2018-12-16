using Autofac;
using Autofac.Integration.WebApi;
using Pokemasters.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace Pokemasters.WebApi
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            var builder = new ContainerBuilder();

            //register api Controllers first
            //matches class of global file
            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly);

            //register dependencies for container
            //can be parameter of IPokemon
            builder.RegisterType<MockPokemonRepository>()
                .As<IPokemon>();

            var container = builder.Build();

            var config = GlobalConfiguration.Configuration;

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }
}

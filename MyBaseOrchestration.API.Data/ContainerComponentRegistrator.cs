using Funq;
using MyBaseOrchestration.API.Data.Interfaces;
using MyBaseOrchestration.API.Data.Factories;                       
using MyBaseOrchestration.API.Data.Repositories;
using ServiceStack.Configuration;

namespace MyBaseOrchestration.API.Data
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            var settings = new AppSettings();                                                                            
            container.Register<IRestServiceFactory>(c => new RestServiceFactory(settings.GetString("LoginService")));
            container.RegisterAutoWiredAs<PersonRepository, IPersonRepository>();

        }
    }
}

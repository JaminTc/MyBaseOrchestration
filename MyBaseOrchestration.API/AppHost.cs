using Funq;
using MyBaseOrchestration.API.ServiceDefinition;
using MyBaseOrchestration.API.ServiceDefinition.Mappers;
using ServiceStack;

namespace MyBaseOrchestration.API
{
    public class AppHost : AppHostBase
    {
        public AppHost() : base(APIInfo.Name, APIInfo.Assembly) { }

        public override void Configure(Container container)
        {
            ContainerManager.Register(container);
            SetConfig(new HostConfig { HandlerFactoryPath = "myFirstApp" });
            AutoMapperConfiguration.Configure();
        }
    }
}
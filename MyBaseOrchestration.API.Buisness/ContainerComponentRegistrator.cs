using Funq;

using MyBaseOrchestration.API.Buisness.Managers;
using MyBaseOrchestration.API.Buisness.Interfaces;

namespace MyBaseOrchestration.API.Buisness
{
    public class ContainerComponentRegistrator
    {
        public static void RegisterComponents(Container container)
        {
            Data.ContainerComponentRegistrator.RegisterComponents(container);
            container.RegisterAutoWiredAs<PersonManager, IPersonManager>();
        }
    }
}

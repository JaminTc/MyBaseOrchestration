using Funq;
using ServiceStack.Validation;

namespace MyBaseOrchestration.API
{
    public static class ContainerManager
    {
        public static void Register(Container container)
        {
            //container.RegisterValidators(ReuseScope.Container, typeof(APIValidat))
            MyBaseOrchestration.API.Buisness.ContainerComponentRegistrator.RegisterComponents(container);
        }
    }
}
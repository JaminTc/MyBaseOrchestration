using AutoMapper;
using dm = MyBaseOrchestration.API.DomainModel;
using sm = MyBaseOrchestration.API.ServiceModel.Dtos;


namespace MyBaseOrchestration.API.ServiceDefinition.Mappers
{
    public class AutoMapperConfiguration
    {
        public static IMapper Configure() 
        {
            var mapperConfig = new MapperConfiguration(
                cfg => cfg.AddProfile<PersonMapper>()
            );
            return mapperConfig.CreateMapper();
        }
    }
}

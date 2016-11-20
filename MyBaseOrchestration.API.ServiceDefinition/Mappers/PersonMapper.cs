using AutoMapper;
using dm = MyBaseOrchestration.API.DomainModel;
using sm = MyBaseOrchestration.API.ServiceModel.Dtos;

namespace MyBaseOrchestration.API.ServiceDefinition.Mappers
{
    internal class PersonMapper : Profile
    {
        public PersonMapper()
        {
            CreateMap<dm.Person, sm.Person>();
            CreateMap<sm.Person, dm.Person>();
        }
    }
}

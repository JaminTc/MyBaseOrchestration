using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MyBaseOrchestration.API.Buisness.Interfaces;
using MyBaseOrchestration.API.ServiceModel.Messages;
using MyBaseOrchestration.API.ServiceDefinition.Mappers;
using ServiceStack;

using dm = MyBaseOrchestration.API.DomainModel;
using sm = MyBaseOrchestration.API.ServiceModel.Dtos;

namespace MyBaseOrchestration.ServiceDefinition
{
    class PersonService : Service
    {
        private IPersonManager _personManager;
        private IMapper _mapper;
        public PersonService(IPersonManager personMgr)
        {
            _personManager = personMgr;
            _mapper = AutoMapperConfiguration.Configure();
        }
        public ReadPersonResponse Get(ReadPerson request)
        {
            var person = new dm.Person { Id = request.PersonId }; 


            var friends = _personManager.GetPerson(person);
            return new ReadPersonResponse() { Person = _mapper.Map<sm.Person>(friends) };
        }
    }
}

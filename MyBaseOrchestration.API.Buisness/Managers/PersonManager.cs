using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBaseOrchestration.API.Buisness.Interfaces;
using MyBaseOrchestration.API.Data.Interfaces;
using MyBaseOrchestration.API.DomainModel;

namespace MyBaseOrchestration.API.Buisness.Managers
{
    internal class PersonManager : RepositoryManager<IPersonRepository>, IPersonManager
    {
        public PersonManager(IPersonRepository repo) : base(repo) { }

        public Person GetPerson(Person person)
        {
            return _repository.GetPerson(person);
        }
    }
}

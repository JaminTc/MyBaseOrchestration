using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBaseOrchestration.API.DomainModel;

namespace MyBaseOrchestration.API.Buisness.Interfaces
{
    public interface IPersonManager
    {
        Person GetPerson(Person person);
    }
}

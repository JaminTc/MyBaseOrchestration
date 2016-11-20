using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyBaseOrchestration.API.Data.Interfaces;

namespace MyBaseOrchestration.API.Data.Repositories
{
    internal abstract class DbRepositoryBase : IRepository
    {
        public readonly IUnitOfWorkFactory _unitOfWorkFactory;
        protected DbRepositoryBase(IUnitOfWorkFactory uowFactory)
        {
            if (uowFactory == null) throw new ArgumentNullException("UnitOfWorkFactory");
            _unitOfWorkFactory = uowFactory;
        }
    }
}

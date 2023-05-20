using PatientVisitDemo.Application.Contracts;
using PatientVisitDemo.Domain.Entities;
using PatientVisitDemo.Persistence.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Persistence.Repositories
{
    internal sealed class AddressRepository: RepositoryBase<Address>, IAddressRepository
    {
        public AddressRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {
            
        }

        public void CreateAddress(Address entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteAddress(Address entity)
        {
            throw new NotImplementedException();
        }

        public Task<Address> GetAddressById(int Id, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Address>> GetAllAsync(bool trackChanges)
        {
            throw new NotImplementedException();
        }
    }
}
 
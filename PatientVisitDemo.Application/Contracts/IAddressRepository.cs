using PatientVisitDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Application.Contracts
{
    public interface IAddressRepository
    {
        Task<IEnumerable<Address>> GetAllAsync(bool trackChanges);
        Task<Address> GetAddressById(int Id, bool trackChanges);
        void CreateAddress(Address entity);
        void DeleteAddress(Address entity);
    }
}

using PatientVisitDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Application.Contracts
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetAllAsync(bool trackChanges);
        Task<Patient> GetPatientByName(string FirstName, string LastName, bool trackChanges);
        void CreateAddress(Patient entity);
        void DeleteAddress(Patient entity);
    }
}

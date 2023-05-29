using PatientVisitDemo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Application.Contracts
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> GetAllDoctorsAsync(bool trackChanges);
        Task<Doctor> GetDoctorByIdAsync(int id, bool trackChanges);
        void CreateDoctor(Doctor doctor);
        void DeleteDoctor(int id);
    }
}

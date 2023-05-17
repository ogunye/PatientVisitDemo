using PatientVisitDemo.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Application.Common
{
    public interface IRepositoryManager
    {
        IAddressRepository AddressRepository { get; }
        IPatientRepository StaffRepository { get; }

        Task SaveAsync();
    }
}

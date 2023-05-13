using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Medical_Center
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}

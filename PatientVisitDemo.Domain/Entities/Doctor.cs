using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Address))]
        public int AddressId { get; set; }
        [ForeignKey(nameof(Medical_Center))]
        public int Medical_Centre_Id { get; set; }

        [MaxLength(100, ErrorMessage ="Maximum character lenght is 100")]
        public string? Doctor_Name { get; set; }

        [MaxLength(300, ErrorMessage = "Maximum character lenght is 300")]
        public string? Doctor_Description { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string? Doctor_Phone { get; set; }

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        
        public double Product_Price { get; set; }
    }
}

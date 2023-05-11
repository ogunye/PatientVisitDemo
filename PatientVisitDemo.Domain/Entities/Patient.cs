using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Address))]
        public int Address_Id { get; set; }


        [Required(ErrorMessage = "First Name is a required field.")]
        [MaxLength(25, ErrorMessage = "FirstName is 25 characters long.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is a required field.")]
        [MaxLength(25, ErrorMessage = "LastName is 25 characters long.")]
        public string? LastName { get; set;}

        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        
        [MaxLength(25, ErrorMessage = "Gender is 6 characters long.")]
        public string? Gender { get; set; }

        [MaxLength(13, ErrorMessage = "Phone is 13 characters long.")]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public DateTime Registred { get; set; } = DateTime.UtcNow;
    }
}

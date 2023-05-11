using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Address
    {
        [Key]
        public int Address_Id { get; set; }

        [Required(ErrorMessage ="House Number is a required field.")]
        [MaxLength(4, ErrorMessage ="House Number is 4 characters long.")]
        public string? Line_1_number_Building { get; set; }

        [Required(ErrorMessage = "Street Name is a required field.")]
        [MaxLength(100, ErrorMessage = "Street Name is 100 characters long.")]
        public string? Street_Name { get; set; }

        [Required(ErrorMessage = "Area Locality is a required field.")]
        [MaxLength(100, ErrorMessage = "Area Locality is 100 characters long.")]
        public string? Area_Locality { get; set; }

        [Required(ErrorMessage = "City is a required field.")]
        [MaxLength(50, ErrorMessage = "City is 50 characters long.")]
        public string? City { get; set; }

        [MaxLength(50, ErrorMessage = "Country is 50 characters long.")]
        public string? Country { get; set; }
    }
}

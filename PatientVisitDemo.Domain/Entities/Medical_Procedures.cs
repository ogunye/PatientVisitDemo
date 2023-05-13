using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Medical_Procedures
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Procedure Name is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum character is 100")]
        public string? Procedure_Name { get; set; }
        public double? Procedure_Price { get; set;}

        [MaxLength(300, ErrorMessage ="Maximum character is 300")]
        public string? Procedure_Description { get; set; }
    }
}

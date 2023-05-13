using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Medication
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Medication Name is a required field.")]
        [MaxLength(50, ErrorMessage ="Maximum character length is 50")]
        public string? Medication_Name { get; set; }

        [MaxLength(500, ErrorMessage = "Maximum character length is 500")]
        public string? Medication_Description { get; set; }
        public double Medication_Cost { get; set; }
    }
}

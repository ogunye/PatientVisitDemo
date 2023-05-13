using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Doctor))]
        public int Doctor_Id { get; set; }
        [ForeignKey(nameof(Patient))]
        public int Patient_Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime Visit_Date { get; set; }
        [DataType(DataType.Time)]
        public TimeSpan Visit_Time { get; set; }
        public double Consultant_Cost { get; set; }
    }
}

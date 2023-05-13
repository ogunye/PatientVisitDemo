using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Entities
{
    public class Visit_Procedure
    {
        [Key, Column(Order = 0)]
        [ForeignKey(nameof(Appointment))]
        public int Visit_Id { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey(nameof(Medical_Procedures))]
        public int Medical_Procedure_Id { get; set; }

        [Range(1, uint.MaxValue)]
        public uint Quantity { get; set; }
        public double Derived_Cost_Procedure { get; set; }

    }
}

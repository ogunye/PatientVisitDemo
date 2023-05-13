using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientVisitDemo.Domain.Common
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get;set; }
        public string? UpdateBy { get; set; }
    }
}

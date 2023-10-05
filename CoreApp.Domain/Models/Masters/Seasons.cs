using CoreApp.Domain.Models.FullyAuditedEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp.Domain.Models.Masters
{
    public class Seasons : FullyAudited
    {
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        public string Season { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string FY { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}

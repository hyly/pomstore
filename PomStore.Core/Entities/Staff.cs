using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomStore.Entities
{
    [Table("Staff")]
    public class Staff : AuditedEntity
    {
        [Required]
        [StringLength(100)]
        public string StaffCode { get; set; }
        [Required]
        [StringLength(100)]
        [Column(TypeName="nvarchar")]
        public string Name { get; set; }
        public int? UserId { get; set; }
    }
}

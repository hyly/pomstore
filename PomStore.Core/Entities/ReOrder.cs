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
    [Table("ReOrder")]
    public class ReOrder : AuditedEntity
    {
        [Required]
        public int OrderId { get; set; }
        [Required]
        public decimal Total { get; set; }
        public decimal? ReturnFee { get; set; }
        [Required]
        public decimal ReOrderTotal { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}

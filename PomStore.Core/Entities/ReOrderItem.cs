using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomStore.Entities
{
    [Table("ReOrderItem")]
    public class ReOrderItem : AuditedEntity
    {
        public int ReOrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }
        [ForeignKey("ReOrderId")]
        public virtual ReOrder ReOrder { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
    }
}

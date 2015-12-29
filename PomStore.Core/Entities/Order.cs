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
    [Table("Order")]
    public class Order : AuditedEntity
    {
        public Order()
        {
            this.ReOrders = new HashSet<ReOrder>();
        }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int StaffId { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        public decimal? Discount { get; set; }
        [Required]
        public decimal? OrderTotal { get; set; }
        public int Status { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("StaffId")]
        public virtual Staff Staff { get; set; }
        public virtual ICollection<ReOrder> ReOrders { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }

    }
}

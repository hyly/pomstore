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
    [Table("Customer")]
    public class Customer : AuditedEntity
    {
        public Customer():base()
        {
            Orders = new HashSet<Order>();
        }
        [StringLength(100)]
        [Required]
        [Column(TypeName = "nvarchar")]
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}

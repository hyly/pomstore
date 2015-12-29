using Abp.Domain.Entities;
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
    [Table("Product")]
    public class Product : AuditedEntity 
    {
        [Required]
        [StringLength(100)]
        [Column(TypeName="nvarchar")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar")]
        public string Description { get; set; }

        [Required]
        public string Sku { get; set; }
        public string Comment { get; set; }
        [Required]
        public decimal SalesPrice { get; set; }
        [Required]
        public decimal OrginalPrice { get; set; }
    }
}

using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using PomStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PomStore.Sales.Dto
{

    [AutoMap(typeof(OrderItem))]
    public class OrderItemDto : IOutputDto
    {
        [DataMember(Name = "orderId")]
        public int OrderId { get; set; }
        [DataMember(Name = "productId")]
        public int ProductId { get; set; }
        [DataMember(Name = "quantity")]
        public int Quantity { get; set; }
        [DataMember(Name = "unitPrice")]
        public decimal UnitPrice { get; set; }
        [DataMember(Name = "totalPrice")]
        public decimal TotalPrice
        {
            get
            {
                if (this.TotalPrice == Decimal.Zero)
                {
                    return this.UnitPrice * this.Quantity;
                }
                return TotalPrice;
            }
            set;
        }
    }
}

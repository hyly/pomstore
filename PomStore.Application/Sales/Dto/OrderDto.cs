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
    [AutoMap(typeof(Order))]
    [DataContract]
    public class OrderDto : IOutputDto
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "customerId")]
        public int CustomerId { get; set; }
        [DataMember(Name = "staffId")]
        public int StaffId { get; set; }
        [DataMember(Name = "total")]
        public decimal Total { get; set; }
        [DataMember(Name = "discount")]
        public decimal? Discount { get; set; }
        [DataMember(Name = "orderTotal")]
        public decimal OrderTotal
        {
            get
            {
                if (this.OrderTotal == Decimal.Zero && this.Items != null && this.Items.Any())
                {
                    return this.Items.Sum(item => item.TotalPrice);
                }
                return this.OrderTotal;
            }
            set;
        }
        [DataMember(Name = "items")]
        public List<OrderItemDto> Items { get; set; }
    }
}

using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PomStore.Sales.Dto
{
    public class CreateOrderInput : IInputDto
    {
        [DataMember(Name = "items")]
        public List<OrderItemDto> Items { get; set; }
        [DataMember(Name = "customerId")]
        public int CustomerId { get; set; }
        [DataMember(Name = "staffId")]
        public int StaffId { get; set; }
    }
}

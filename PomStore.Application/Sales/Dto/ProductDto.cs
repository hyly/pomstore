using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.AutoMapper;
using PomStore.Entities;
using System.Runtime.Serialization;
namespace PomStore.Sales.Dto
{
    [AutoMap(typeof(Product))]
    [DataContract]
    public class ProductDto : IInputDto
    {
        [DataMember(Name="id")]
        public int Id { get; set; }
        [DataMember(Name="name")]
        public string Name { get; set; }
        [DataMember(Name="description")]
        public string Description { get; set; }
        [DataMember(Name="price")]
        public decimal SalesPrice { get; set; }

    }
}

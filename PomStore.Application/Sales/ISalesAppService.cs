using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomStore.Sales.Dto;
namespace PomStore.Sales
{
    public interface ISalesAppService:IApplicationService
    {
        OrderDto CreateOrder(CreateOrderInput input);
        ReOrderDto CreateReOrder(CreateReOrderInput input);
        List<ProductDto> SearchProductByName(string name);
    }
}

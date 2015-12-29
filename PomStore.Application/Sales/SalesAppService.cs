using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomStore.Sales
{
    public class SalesAppService : ApplicationService, ISalesAppService
    {
        public Dto.SalesServiceOutput CreateOrder(Dto.CreateOrderInput input)
        {
            throw new NotImplementedException();
        }

        public Dto.SalesServiceOutput CreateReOrder(Dto.CreateReOrderInput input)
        {
            throw new NotImplementedException();
        }
    }
}

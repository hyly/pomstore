using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.AutoMapper;
using PomStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PomStore.Sales.Dto;
using AutoMapper;
using Abp.Domain.Uow;

namespace PomStore.Sales
{
    public class SalesAppService : PomStoreAppServiceBase, ISalesAppService
    {
        private readonly IRepository<Product> productRepo = null;
        private readonly IRepository<Customer> customerRepo = null;
        private readonly IRepository<Staff> staffRepo = null;
        private readonly IRepository<Order> orderRepo = null;
        private readonly IRepository<ReOrder> reOrderRepo = null;
        private readonly IUnitOfWorkManager unitOfWork = null;
        public SalesAppService(
            IUnitOfWorkManager unitOfWork,
            IRepository<Product> productRepository,
            IRepository<Customer> customerRepository,
            IRepository<Staff> staffRepository,
            IRepository<Order> orderRepository,
            IRepository<ReOrder> reOrderRepository)
            :base()
        {
            this.unitOfWork = unitOfWork;
            this.productRepo = productRepository;
            this.customerRepo = customerRepository;
            this.staffRepo = staffRepository;
            this.orderRepo = orderRepository;
            this.reOrderRepo = reOrderRepository;
        }
        public OrderDto CreateOrder(OrderDto order)
        {
            if (order == null)
            {
                throw new ArgumentNullException("order", L("NullException"));
            }
            using (var unit = unitOfWork.Begin())
            {
                var entity = this.orderRepo.Insert(Mapper.Map<Order>(order));
                unit.Complete();
                order.Id = entity.Id;
                return order;
            }
            
           
        }

        public ReOrderDto CreateReOrder(CreateReOrderInput input)
        {
            throw new NotImplementedException();
        }


        public List<Dto.ProductDto> SearchProductByName(string name)
        {
            var entities = this.productRepo.GetAllList(e => e.Name.Contains(name)).Select(e => e.MapTo<ProductDto>()).ToList();
            return entities;
        }
    }
}

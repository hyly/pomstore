using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using PomStore.Authorization.Roles;
using PomStore.Editions;
using PomStore.Users;

namespace PomStore.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, Role, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager
            )
        {
        }
    }
}
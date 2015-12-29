using Abp.Application.Features;
using PomStore.Authorization.Roles;
using PomStore.MultiTenancy;
using PomStore.Users;

namespace PomStore.Features
{
    public class FeatureValueStore : AbpFeatureValueStore<Tenant, Role, User>
    {
        public FeatureValueStore(TenantManager tenantManager)
            : base(tenantManager)
        {
        }
    }
}
using Abp.Authorization.Roles;
using PomStore.MultiTenancy;
using PomStore.Users;

namespace PomStore.Authorization.Roles
{
    public class Role : AbpRole<Tenant, User>
    {

    }
}
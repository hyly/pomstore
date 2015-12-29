using Abp.Authorization;
using PomStore.Authorization.Roles;
using PomStore.MultiTenancy;
using PomStore.Users;

namespace PomStore.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

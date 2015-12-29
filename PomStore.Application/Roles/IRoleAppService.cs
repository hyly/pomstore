using System.Threading.Tasks;
using Abp.Application.Services;
using PomStore.Roles.Dto;

namespace PomStore.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}

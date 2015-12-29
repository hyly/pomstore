using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using PomStore.MultiTenancy.Dto;

namespace PomStore.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultOutput<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}

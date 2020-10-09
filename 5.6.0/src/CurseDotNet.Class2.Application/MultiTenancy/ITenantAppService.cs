using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CurseDotNet.Class2.MultiTenancy.Dto;

namespace CurseDotNet.Class2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

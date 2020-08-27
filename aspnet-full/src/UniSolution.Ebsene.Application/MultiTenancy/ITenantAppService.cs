using Abp.Application.Services;
using Abp.Application.Services.Dto;
using UniSolution.Ebsene.MultiTenancy.Dto;

namespace UniSolution.Ebsene.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


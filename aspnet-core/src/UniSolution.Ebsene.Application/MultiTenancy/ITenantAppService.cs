using Abp.Application.Services;
using UniSolution.Ebsene.MultiTenancy.Dto;

namespace UniSolution.Ebsene.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


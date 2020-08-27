using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Extensions;
using Abp.Linq.Extensions;
using System.Linq;

namespace UniSolution.Ebsene.Tanks
{
    using Dto;

    [AbpAuthorize]
    public class TankAppService: AsyncCrudAppService<Tank, TankDto, string, PagedTankResultRequestDto, CreateTankDto, TankDto>, ITankAppService
    {
        public TankAppService(IRepository<Tank, string> tankRepository) 
            :base(tankRepository)
        {
            
        }

        protected override IQueryable<Tank> CreateFilteredQuery(PagedTankResultRequestDto input)
        {
            return Repository.GetAll()
                .WhereIf(!input.Keyword.IsNullOrWhiteSpace(), x => x.Id.Contains(input.Keyword) || x.ProductType.Contains(input.Keyword))
                .WhereIf(input.IsActive.HasValue, x => x.IsDeleted == input.IsActive);
        }
    }
}
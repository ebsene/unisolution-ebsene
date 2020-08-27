using Abp.Application.Services;

namespace UniSolution.Ebsene.Tanks
{
    using Dto;

    public interface ITankAppService: IAsyncCrudAppService<TankDto, string, PagedTankResultRequestDto, CreateTankDto, TankDto>
    {
         
    }
}
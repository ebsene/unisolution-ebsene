using System.Threading.Tasks;
using Abp.Application.Services;
using UniSolution.Ebsene.Sessions.Dto;

namespace UniSolution.Ebsene.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

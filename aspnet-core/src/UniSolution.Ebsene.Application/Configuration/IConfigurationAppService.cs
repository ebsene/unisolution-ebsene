using System.Threading.Tasks;
using UniSolution.Ebsene.Configuration.Dto;

namespace UniSolution.Ebsene.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

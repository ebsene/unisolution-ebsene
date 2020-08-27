using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using UniSolution.Ebsene.Configuration.Dto;

namespace UniSolution.Ebsene.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : EbseneAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

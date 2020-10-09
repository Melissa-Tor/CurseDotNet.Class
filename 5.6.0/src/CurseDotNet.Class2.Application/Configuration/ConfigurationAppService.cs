using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CurseDotNet.Class2.Configuration.Dto;

namespace CurseDotNet.Class2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : Class2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

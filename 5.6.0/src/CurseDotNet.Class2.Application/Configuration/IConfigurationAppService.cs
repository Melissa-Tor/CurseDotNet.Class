using System.Threading.Tasks;
using Abp.Application.Services;
using CurseDotNet.Class2.Configuration.Dto;

namespace CurseDotNet.Class2.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
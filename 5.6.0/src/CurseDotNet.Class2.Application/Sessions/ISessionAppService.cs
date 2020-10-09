using System.Threading.Tasks;
using Abp.Application.Services;
using CurseDotNet.Class2.Sessions.Dto;

namespace CurseDotNet.Class2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

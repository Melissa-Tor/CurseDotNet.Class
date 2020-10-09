using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CurseDotNet.Class2.Roles.Dto;
using CurseDotNet.Class2.Users.Dto;

namespace CurseDotNet.Class2.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}
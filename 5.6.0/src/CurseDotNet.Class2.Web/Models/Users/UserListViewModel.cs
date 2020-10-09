using System.Collections.Generic;
using CurseDotNet.Class2.Roles.Dto;
using CurseDotNet.Class2.Users.Dto;

namespace CurseDotNet.Class2.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
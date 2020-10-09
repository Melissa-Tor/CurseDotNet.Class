using System.Collections.Generic;
using System.Linq;
using CurseDotNet.Class2.Roles.Dto;
using CurseDotNet.Class2.Users.Dto;

namespace CurseDotNet.Class2.Web.Models.Users
{
    public class EditUserModalViewModel
    {
        public UserDto User { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }

        public bool UserIsInRole(RoleDto role)
        {
            return User.Roles != null && User.Roles.Any(r => r == role.Name);
        }
    }
}
using Abp.Authorization;
using CurseDotNet.Class2.Authorization.Roles;
using CurseDotNet.Class2.Authorization.Users;

namespace CurseDotNet.Class2.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}

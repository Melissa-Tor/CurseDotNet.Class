﻿using System.Collections.Generic;
using System.Linq;
using CurseDotNet.Class2.Roles.Dto;

namespace CurseDotNet.Class2.Web.Models.Roles
{
    public class EditRoleModalViewModel
    {
        public RoleDto Role { get; set; }

        public IReadOnlyList<PermissionDto> Permissions { get; set; }

        public bool HasPermission(PermissionDto permission)
        {
            return Permissions != null && Role.GrantedPermissions.Any(p => p == permission.Name);
        }
    }
}
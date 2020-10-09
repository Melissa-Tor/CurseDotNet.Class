using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using CurseDotNet.Class2.Authorization.Users;
using CurseDotNet.Class2.MultiTenancy;
using CurseDotNet.Class2.Users;
using Microsoft.AspNet.Identity;

namespace CurseDotNet.Class2
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class Class2AppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected Class2AppServiceBase()
        {
            LocalizationSourceName = Class2Consts.LocalizationSourceName;
        }

        protected virtual async Task<User> GetCurrentUserAsync()
        {
            var user = await UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
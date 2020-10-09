using Abp.MultiTenancy;
using CurseDotNet.Class2.Authorization.Users;

namespace CurseDotNet.Class2.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
using System.Linq;
using CurseDotNet.Class2.EntityFramework;
using CurseDotNet.Class2.MultiTenancy;

namespace CurseDotNet.Class2.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly Class2DbContext _context;

        public DefaultTenantCreator(Class2DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}

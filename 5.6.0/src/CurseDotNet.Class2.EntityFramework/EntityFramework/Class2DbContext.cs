using System.Data.Common;
using System.Data.Entity;
using Abp.DynamicEntityParameters;
using Abp.Zero.EntityFramework;
using CurseDotNet.Class2.Authorization.Roles;
using CurseDotNet.Class2.Authorization.Users;
using CurseDotNet.Class2.Features.Clientes;
using CurseDotNet.Class2.Features.Productos;
using CurseDotNet.Class2.MultiTenancy;

namespace CurseDotNet.Class2.EntityFramework
{
    public class Class2DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        DbSet<Producto> Productos { get; set; }
        DbSet<Clientes> Clientes { get; set; }

            /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public Class2DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in Class2DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of Class2DbContext since ABP automatically handles it.
         */
        public Class2DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public Class2DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public Class2DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicParameter>().Property(p => p.ParameterName).HasMaxLength(250);
            modelBuilder.Entity<EntityDynamicParameter>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}

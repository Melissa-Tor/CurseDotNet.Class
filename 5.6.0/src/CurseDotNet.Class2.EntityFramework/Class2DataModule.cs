using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using CurseDotNet.Class2.EntityFramework;

namespace CurseDotNet.Class2
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(Class2CoreModule))]
    public class Class2DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<Class2DbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}

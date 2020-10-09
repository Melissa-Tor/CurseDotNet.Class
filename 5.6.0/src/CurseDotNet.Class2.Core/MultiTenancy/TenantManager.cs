using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using CurseDotNet.Class2.Authorization.Users;
using CurseDotNet.Class2.Editions;

namespace CurseDotNet.Class2.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore
            ) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore
            )
        {
        }
    }
}
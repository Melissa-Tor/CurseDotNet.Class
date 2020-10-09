using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CurseDotNet.Class2.MultiTenancy;

namespace CurseDotNet.Class2.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
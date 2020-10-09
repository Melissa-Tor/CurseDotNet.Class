using Abp.AutoMapper;
using CurseDotNet.Class2.Sessions.Dto;

namespace CurseDotNet.Class2.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using UniSolution.Ebsene.MultiTenancy;

namespace UniSolution.Ebsene.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}

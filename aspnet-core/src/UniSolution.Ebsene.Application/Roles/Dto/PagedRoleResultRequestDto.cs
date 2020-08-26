using Abp.Application.Services.Dto;

namespace UniSolution.Ebsene.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


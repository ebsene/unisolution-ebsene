using Abp.Application.Services.Dto;

namespace UniSolution.Ebsene.Tanks.Dto
{
    public class PagedTankResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}


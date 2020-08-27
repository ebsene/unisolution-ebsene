using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace UniSolution.Ebsene.Tanks.Dto
{
    [AutoMap(typeof(Tank))]
    public class TankDto: FullAuditedEntityDto<string>
    {
        public decimal Capacity { get; set; }

        [Required]
        [StringLength(Tank.MaxProductTypeLength)]
        public string ProductType { get; set; }
    }
}
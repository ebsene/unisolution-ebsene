using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace UniSolution.Ebsene.Tanks.Dto
{
    [AutoMapTo(typeof(Tank))]
    public class CreateTankDto
    {
        [Required]
        [StringLength(Tank.MaxIdLength)]
        public string Id { get; set; }

        public decimal Capacity { get; set; }

        [Required]
        [StringLength(Tank.MaxProductTypeLength)]
        public string ProductType { get; set; }
    }
}
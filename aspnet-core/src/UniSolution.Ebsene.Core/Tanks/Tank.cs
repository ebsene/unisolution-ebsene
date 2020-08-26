using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;

namespace UniSolution.Ebsene.Tanks
{
    [Table("Tanque")]
    public class Tank : FullAuditedEntity<string>
    {
        public const int MaxIdLength = 1024;
        public const int MaxProductTypeLength = 512;


        [Column("Deposito")]
        [StringLength(MaxIdLength)]
        public override string Id { get; set; }

        [Column("Capacidade")]
        public decimal Capacity { get; set; }

        [Required]
        [Column("TipoDeProduto")]
        [StringLength(MaxProductTypeLength)]
        public string ProductType { get; set; }
    }
}
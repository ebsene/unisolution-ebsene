using System.ComponentModel.DataAnnotations;

namespace UniSolution.Ebsene.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace ABP_Web_Core.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
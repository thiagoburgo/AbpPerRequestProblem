using System.ComponentModel.DataAnnotations;

namespace PerRequestProblemSite.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
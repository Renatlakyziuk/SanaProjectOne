using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class HomePageModel
    {
        [Display(Name = "Your name")]
        [Required(ErrorMessage = "*")]
        public string Name { get; set; } = "";
    }
}
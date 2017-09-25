using System.ComponentModel.DataAnnotations;

namespace E_Contact.ViewModels
{
    public class HomeViewModel
    {
        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage = "NotAValidEmail")]
        [Display(Name = "YourEmail")]
        public string Email { get; set; }
    }
}

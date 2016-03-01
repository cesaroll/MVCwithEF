using System.ComponentModel.DataAnnotations;

namespace S15_L59_Validation.Models
{
    public class User
    {
        [Required(ErrorMessage = "*")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "*")]
        public string Password { get; set; }

        [Compare("Password")]
        [Required(ErrorMessage = "*")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "*")]
        public string Qualification { get; set; }

        [Required(ErrorMessage = "*")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "*")]
        public double CurrentCTC { get; set; }

        [Range(8,12)]
        [Required(ErrorMessage = "*")]
        public double ExpectedCTC { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "*")]
        public string Email { get; set; }

        [Url]
        [Required(ErrorMessage = "*")]
        public string Url { get; set; }
    }
}
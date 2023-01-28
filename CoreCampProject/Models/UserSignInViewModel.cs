using System.ComponentModel.DataAnnotations;

namespace CoreCampProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Lütfen kullanıcı adını girin")]
        public string username { get; set; }
        [Required(ErrorMessage = "Lütfen kullanıcı şifrenizi girin")]
        public string password { get; set; }
    }
}

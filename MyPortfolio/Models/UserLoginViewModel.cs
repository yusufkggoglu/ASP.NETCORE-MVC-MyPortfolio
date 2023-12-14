using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyPortfolio.Models
{
    public class UserLoginViewModel
    {
        [DisplayName("Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adı giriniz !")]
        public string Username { get; set; }

        [DisplayName("Şifre")]
        [Required(ErrorMessage = "Şifre giriniz !")]
        public string Password { get; set; }
    }
}

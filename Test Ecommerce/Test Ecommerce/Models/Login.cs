using System.ComponentModel.DataAnnotations;

namespace Test_Ecommerce.Model
{
    public class Login
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

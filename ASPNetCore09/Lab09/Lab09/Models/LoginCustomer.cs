using System.ComponentModel.DataAnnotations;

namespace Lab09.Models
{
    public class LoginCustomer
    {
        [Required(ErrorMessage = "Địa chỉ email không được để trống")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }
        public bool Remember { get; set; }
    }
}

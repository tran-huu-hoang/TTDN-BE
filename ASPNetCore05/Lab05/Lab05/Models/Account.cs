using System.ComponentModel.DataAnnotations;

namespace Lab05.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Họ tên từ 6-20 kí tự")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,11}", ErrorMessage = "Phải bắt đầu từ 0 và độ dài từ 10-12 số")]
        public string Phone { get; set; }

        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống")]
        [StringLength(35, ErrorMessage = "Địa chỉ không được quá 35 kí tự")]
        public string Address { get; set; }

        [Display(Name = "Ảnh đại diện")]
        [Required(ErrorMessage = "Ảnh đại diện không được để trống")]
        public string Avatar { get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Giới tính không được để trống")]
        public string Gender { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Link Facebook")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https")]
        public string Facebook { get; set; }
    }
}

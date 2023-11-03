using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab05_eg.Models.ModelViews
{
    public class MemberView
    {
        public int MemberId { get; set; }

        [DisplayName("Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(20, MinimumLength =3, ErrorMessage = "Độ dài tên từ 3-20 lí tự")]
        public string UserName { get; set; }

        [DisplayName("Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string FullName { get; set; }

        [DisplayName("Mật khẩu")]
        [Required(ErrorMessage = "Hãy nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Nhập lại mật khẩu")]
        [Required(ErrorMessage = "Hãy nhập lại mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp, hãy nhập lại")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [DisplayName("Hòm thư")]
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"[a-zA-Z0-9._+-]+@[a-z0-9._]+\.[a-z]{2,4}$", ErrorMessage = "Sai định dạng email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        [RegularExpression(@"^0\d{9,11}", ErrorMessage = "Phải bắt đầu từ 0 và độ dài từ 10-12 số")]
        public string Phone { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime? Birthday { get; set; }
    }
}

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class People
    {
        public int Id { get; set; }
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Địa chỉ email")]
        public string Email { get; set; }
        [Display(Name = "Số điện thoại")]
        public string Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }
        [Display(Name = "Ảnh đại diện")]
        public string Avatar { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime Birthday { get; set; }
        [Display(Name = "Giới thiệu bản thân")]
        public string Bio { get; set; }
        [Display(Name = "Giới tính")]
        public byte Gender { get; set; }
    }
}

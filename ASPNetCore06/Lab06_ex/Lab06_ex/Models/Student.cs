using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06_ex.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sinh viên không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Tên sinh viên không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        public string StudentEmail { get; set; }

        [Required(ErrorMessage = "Tên sinh viên không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        public string StudentPhone { get; set; }

        [Required(ErrorMessage = "Tên sinh viên không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        public string StudentAddress { get; set; }

        [Required(ErrorMessage = "Tên sinh viên không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        public string StudentAvatar { get; set; }

        public DateTime StudentBirthday { get; set; }

        public int ClassId { get; set; }

        //khóa ngoại
        public virtual StdClass? StdClass { get; set; }

        public ICollection<Marks> Marks  { get; set; }
    }
}

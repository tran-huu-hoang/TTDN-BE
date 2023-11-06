using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06_practice.Models
{
    [Table("StdClass")]
    public class StdClass
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên lớp không được để trống")]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string ClassName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}

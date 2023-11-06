using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06_practice.Models
{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên môn học không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        [StringLength(100)]
        public string SubjectName { get; set; }
    }
}

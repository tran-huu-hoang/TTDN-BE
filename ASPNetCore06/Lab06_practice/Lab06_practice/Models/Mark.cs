using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06_practice.Models
{
    [Table("Marks")]
    [PrimaryKey(nameof(SubjectId), nameof(StudentId))]
    public class Mark
    {
        public int SubjectId { get; set; }

        public int StudentId { get; set; }

        [Required(ErrorMessage = "Điểm không được để trống")]
        public float Score { get; set; }

        public virtual Student? Student { get; set; }
        public virtual Subject? Subject { get; set; }
    }
}

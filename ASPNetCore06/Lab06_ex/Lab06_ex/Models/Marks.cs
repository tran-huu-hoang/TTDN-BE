using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab06_ex.Models
{
    [Table("Marks")]
    [Keyless]
    public class Marks
    {
        public int SubjectId { get; set; }

        public int StudentId { get; set; }

        [Required(ErrorMessage = "Điểm không được để trống")]
        public float Score { get; set; }

        public virtual Subjects Subjects { get; set; }
        public virtual Student Students { get; set; }
    }
}

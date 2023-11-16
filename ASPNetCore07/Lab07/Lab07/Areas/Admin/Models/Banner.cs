using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab07.Areas.Admin.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        public string Name { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Status { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Prioty { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Image { get; set; }

        [Column(TypeName = "nvarchar(350)")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Decription { get; set; }
    }
}

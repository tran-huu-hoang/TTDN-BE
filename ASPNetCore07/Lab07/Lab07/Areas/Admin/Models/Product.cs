using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab07.Areas.Admin.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống")]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá sản phẩm không được để trống")]
        public float Price { get; set; }

        [Required(ErrorMessage = "Giá ưu đãi không được để trống")]
        public float SalePrice { get; set; }

        [Column(TypeName = "tinyint")]
        public byte Status { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string Image { get; set; }

        [Column(TypeName = "nvarchar(350)")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        public string Decription { get; set; }

        //khóa ngoại
        public virtual Category? Category { get; set; }
    }
}

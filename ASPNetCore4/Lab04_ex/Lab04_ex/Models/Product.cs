using System.ComponentModel.DataAnnotations;

namespace Lab04_ex.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Display(Name = "Tên")]
        public string Name { get; set; }
        [Display(Name = "Giá")]
        public double Price { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
        [Display(Name = "Ngày đăng")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }
        [Display(Name = "Mô tả")]
        public string Decription { get; set; }

        public virtual Category? Category { get; set; }
    }
}

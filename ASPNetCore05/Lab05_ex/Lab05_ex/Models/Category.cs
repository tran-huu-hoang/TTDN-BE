using System.ComponentModel.DataAnnotations;

namespace Lab05_ex.Models
{
    public class Category
    {
        [Display(Name = "Id danh mục")]
        public int Id { get; set; }
        [Display(Name = "Tên danh mục")]
        public string Name { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Người tạo")]
        public string CreateBy { get; set; }
        [Display(Name = "Trạng thái")]
        public bool Status { get; set; }
        public ICollection<Product> Product { get; set; } = new List<Product>();
    }
}

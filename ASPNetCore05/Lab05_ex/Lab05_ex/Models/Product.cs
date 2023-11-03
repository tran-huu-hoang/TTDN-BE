using System.ComponentModel.DataAnnotations;

namespace Lab05_ex.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Tên không được để trống")]
        [StringLength(150, MinimumLength = 6, ErrorMessage = "Tên phải có độ dài 6-150 kí tự")]
        public string Name { get; set; }

        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(100000, double.MaxValue, ErrorMessage = "Giá nhỏ nhất là 100000")]
        [DataType(DataType.Text)]
        public double Price { get; set; }

        [Display(Name = "Giá ưu đãi")]
        [Required(ErrorMessage = "Giá ưu đãi không được để trống")]
        [Range(0, 90000, ErrorMessage = "Giá ưu đãi phải không âm và nhỏ hơn giá gốc 10%")]
        [DataType(DataType.Text)]
        public double SalePrice { get; set; }

        [Display(Name = "Trạng thái")]
        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public bool Status { get; set; }

        [Display(Name = "Ngày đăng")]
        [Required(ErrorMessage = "Ngày đăng không được để trống")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Hình ảnh")]
        [Required(ErrorMessage = "Hình ảnh không được để trống")]
        public string Image { get; set; }

        [Display(Name = "Danh mục")]
        [Required(ErrorMessage = "Danh mục không được để trống")]
        [Range(1, int.MaxValue, ErrorMessage = "Id danh mục không hợp lệ")]
        public int CategoryId { get; set; }

        [Display(Name = "Mô tả")]
        [Required(ErrorMessage = "Mô tả không được để trống")]
        [StringLength(1500, ErrorMessage = "Không được nhập quá 1500 kí tự")]
        [RegularExpression(@"^(?!.*\b(die|admin|cunt|fuck|shit)\b).*$", ErrorMessage = "Không được chứa các từ nhạy cảm")]
        public string Decription { get; set; }

        public virtual Category? Category { get; set; }
    }
}

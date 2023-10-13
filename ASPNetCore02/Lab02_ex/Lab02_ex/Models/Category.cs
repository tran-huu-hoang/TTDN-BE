namespace Lab02_ex.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set; }
        public int CategoryId { get; set; }
        public string Decription { get; set; }
        public int Status { get; set; }
        public DateTime CreateAt { get; set; }
    }
}

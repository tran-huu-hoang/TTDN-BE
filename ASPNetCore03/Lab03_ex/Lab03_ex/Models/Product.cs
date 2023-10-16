namespace Lab03_ex.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }

        public List<Product> GetProductList()
        {
            List<Product> list = new List<Product>()
            {
                new Product { Id = 1, Image = "/images/katana.jfif", Name = "Katana chém sắt như chém bùn"},
            new Product { Id = 2, Image = "/images/katana.jfif", Name = "Katana chém sắt như chém chuối"},
            new Product { Id = 3, Image = "/images/katana.jfif", Name = "Katana chém sắt như chém táo"},
            };

            return list;
        }
    }
}

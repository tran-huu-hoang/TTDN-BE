namespace Lab04_ex.Models
{
    public class DataLocal
    {
        public static List<Product> products = new List<Product>()
        {
            new Product
            {
                Id = 1,
                Name = "Cõi Mộng Ngàn Đêm",
                Price = 1000,
                Status = true,
                CreateDate = Convert.ToDateTime("2000/02/03"),
                Image = "images/anh1.png",
                CategoryId = 1,
                Decription = "Chất lượng cao",
            },
            new Product
            {
                Id = 2,
                Name = "Nhược Thủy",
                Price = 2000,
                Status = false,
                CreateDate = Convert.ToDateTime("2000/02/03"),
                Image = "images/anh2.png",
                CategoryId = 2,
                Decription = "Chất lượng cao",
            },
            new Product
            {
                Id = 3,
                Name = "Tiếng thở dài vô tận",
                Price = 3000,
                Status = true,
                CreateDate = Convert.ToDateTime("2000/02/03"),
                Image = "images/anh3.png",
                CategoryId = 2,
                Decription = "Chất lượng cao",
            },
            new Product
            {
                Id = 4,
                Name = "Đoạn Thảo Trường Đao",
                Price = 4000,
                Status = true,
                CreateDate = Convert.ToDateTime("2000/02/03"),
                Image = "images/anh4.png",
                CategoryId = 3,
                Decription = "Chất lượng cao",
            },
            new Product
            {
                Id = 5,
                Name = "Con Đường Thợ Săn",
                Price = 5000,
                Status = true,
                CreateDate = Convert.ToDateTime("2000/02/03"),
                Image = "images/anh5.png",
                CategoryId = 2,
                Decription = "Chất lượng cao",
            },
            new Product
            {
                Id = 6,
                Name = "Ánh Sáng Đêm Sương Mù",
                Price = 6000,
                Status = true,
                CreateDate = Convert.ToDateTime("2000/02/03"),
                Image = "images/anh6.png",
                CategoryId = 4,
                Decription = "Chất lượng cao",
            },
        };

        public static List<Product> GetProducts()
        {
            return products;
        }

        public static Product GetProductById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public static List<Category> categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Pháp khí", CreateDate = DateTime.Now, CreateBy = "Hoàng", Status = true},
            new Category { Id = 2, Name = "Cung", CreateDate = DateTime.Now, CreateBy = "Hoàng", Status = false},
            new Category { Id = 3, Name = "Vũ khí cán dài", CreateDate = DateTime.Now, CreateBy = "Hoàng", Status = false},
            new Category { Id = 4, Name = "Kiếm đơn", CreateDate = DateTime.Now, CreateBy = "Hoàng", Status = true},
        };

        public static List<Category> GetCategory()
        {
            return categories;
        }
    }
}

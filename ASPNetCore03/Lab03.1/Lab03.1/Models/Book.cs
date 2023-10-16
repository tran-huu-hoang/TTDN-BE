using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab03._1.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image {  get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }

        public List<Book> GetBookList()
        {
            List<Book> list = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenreId = 1,
                    Image = "/images/anh1.jfif",
                    Price = 10000,
                    Sumary = "",
                    TotalPage = 109,
                },
                new Book()
                {
                    Id = 2,
                    Title = "Chi Pheo",
                    AuthorId = 2,
                    GenreId = 2,
                    Image = "/images/anh1.jfif",
                    Price = 20000,
                    Sumary = "",
                    TotalPage = 209,
                },
                new Book()
                {
                    Id = 3,
                    Title = "Chi Pheo",
                    AuthorId = 3,
                    GenreId = 3,
                    Image = "/images/anh1.jfif",
                    Price = 30000,
                    Sumary = "",
                    TotalPage = 309,
                },
                new Book()
                {
                    Id = 4,
                    Title = "Chi Pheo",
                    AuthorId = 4,
                    GenreId = 4,
                    Image = "/images/anh1.jfif",
                    Price = 40000,
                    Sumary = "",
                    TotalPage = 409,
                },
            };

            return list;
        }

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value = "1", Text = "Nam Cao"},
            new SelectListItem{Value = "2", Text = "Ngô Tất Tố"},
            new SelectListItem{Value = "3", Text = "Xuân Diệu"},
            new SelectListItem{Value = "4", Text = "Xuân Quỳnh"},
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value = "1", Text = "Truyện tranh"},
            new SelectListItem{Value = "2", Text = "Truyện ngắn"},
            new SelectListItem{Value = "3", Text = "Thơ lục bát"},
            new SelectListItem{Value = "4", Text = "Truyện cười"},
        };
    }
}

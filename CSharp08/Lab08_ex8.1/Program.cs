using Lab08_ex8._1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Book> listBook = new List<Book>()
        {
            new Book{Id = "B01", Name = "Co hoi cua chua", Author = "Nguyễn Việt Hà", Publisher = "Nhi Dong", Year = 2014, Price = 58000},
            new Book{Id = "B02", Name = "Tuoi 20 yeu dau", Author = "Nguyễn Huy Tiệp", Publisher = "Tien Phong", Year = 2000, Price = 1990},
            new Book{Id = "B03", Name = "Lập trình", Author = "Phùng Quán", Publisher = "Nhi Dong", Year = 1976, Price = 780},
            new Book{Id = "B04", Name = "Kiet tac cua su song", Author = "Cao Bảo Anh", Publisher = "Giáo dục", Year = 1978, Price = 1670},
            new Book{Id = "B05", Name = "Toi va the gioi", Author = "Nguyễn Phi Vân", Publisher = "Tien Phong", Year = 2003, Price = 4090},
            new Book{Id = "B06", Name = "Dung viec", Author = "Giản Tư Trung", Publisher = "Kim Dong", Year = 2015, Price = 2780},
            new Book{Id = "B07", Name = "Toi tu hoc", Author = "Nguyễn Duy Cần", Publisher = "Giáo dục", Year = 2014, Price = 6760},
            new Book{Id = "B08", Name = "Cho toi xin mot ve so", Author = "Nguyễn Nhật Ánh", Publisher = "Kim Dong", Year = 1698, Price = 167},
            new Book{Id = "B09", Name = "Lập trình", Author = "Nguyễn Nhật Ánh", Publisher = "Tien Phong", Year = 2015, Price = 2950},
            new Book{Id = "B10", Name = "Hom nay toi that tinh", Author = "Hạ Vũ", Publisher = "Giáo dục", Year = 2001, Price = 490},
        };

        Console.WriteLine("Hiển thị tất cả sách: ");
        foreach(var item in listBook)
        {
            Console.WriteLine("\tId: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", item.Id, item.Name, item.Author, item.Price, item.Publisher, item.Year);
        }

        IEnumerable<Book> queryPrice = listBook.Where(b => b.Price >= 1000 && b.Price <= 5000);
        Console.WriteLine("\n\nHiển thị những quyển sách có giá từ 1000-5000: ");
        foreach (var item in queryPrice)
        {
            Console.WriteLine("\tId: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", item.Id, item.Name, item.Author, item.Price, item.Publisher, item.Year);
        }

        IEnumerable<Book> queryYear = listBook.Where(b => b.Year == 2015);
        Console.WriteLine("\n\nHiển thị những quyển sách xuất bản năm 2015: ");
        foreach (var item in queryYear)
        {
            Console.WriteLine("\tId: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", item.Id, item.Name, item.Author, item.Price, item.Publisher, item.Year);
        }

        IEnumerable<Book> queryName = listBook.Where(b => b.Name.Contains("Lập trình"));
        Console.WriteLine("\n\nHiển thị những quyển sách có tên Lập trình: ");
        foreach (var item in queryName)
        {
            Console.WriteLine("\tId: {0}, Name: {1}, Author: {2}, Price: {3}, Publisher: {4}, Year: {5}", item.Id, item.Name, item.Author, item.Price, item.Publisher, item.Year);
        }

        var countPublisher = listBook.Where(b => b.Publisher.Contains("Giáo dục")).Distinct().Count();
        Console.WriteLine("\n\nSố quyển sách của nhà xuất bản Giáo Dục: " + countPublisher);
    }
}
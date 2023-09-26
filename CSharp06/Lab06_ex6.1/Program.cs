using Lab06_ex6._1;
using System.Collections;
using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> listBook = new List<Book>()
        {
            new Book{Id = "B01", Title = "Co hoi cua chua", Author = "Nguyễn Việt Hà", Publisher = "Nhi Dong", Year = 2014, Price = 200},
            new Book{Id = "B02", Title = "Tuoi 20 yeu dau", Author = "Nguyễn Huy Tiệp", Publisher = "Tien Phong", Year = 2000, Price = 199},
            new Book{Id = "B03", Title = "Tuoi tho du doi", Author = "Phùng Quán", Publisher = "Nhi Dong", Year = 1976, Price = 278},
            new Book{Id = "B04", Title = "He mien dich, kiet tac cua su song", Author = "Cao Bảo Anh", Publisher = "Thanh nien", Year = 1978, Price = 167},
            new Book{Id = "B05", Title = "Toi, tuong lai va the gioi", Author = "Nguyễn Phi Vân", Publisher = "Tien Phong", Year = 2003, Price = 409},
            new Book{Id = "B06", Title = "Dung viec", Author = "Giản Tư Trung", Publisher = "Kim Dong", Year = 1876, Price = 278},
            new Book{Id = "B07", Title = "Toi tu hoc", Author = "Nguyễn Duy Cần", Publisher = "Nhi Dong", Year = 2014, Price = 476},
            new Book{Id = "B08", Title = "Cho toi xin mot ve di tuoi tho", Author = "Nguyễn Nhật Ánh", Publisher = "Kim Dong", Year = 1698, Price = 167},
            new Book{Id = "B09", Title = "Co gai den tu hom qua", Author = "Nguyễn Nhật Ánh", Publisher = "Tien Phong", Year = 1878, Price = 295},
            new Book{Id = "B010", Title = "Hom nay toi that tinh", Author = "Hạ Vũ", Publisher = "Thanh nien", Year = 2001, Price = 149},
        };

        //in ra danh sách tăng dần theo giá
        Console.WriteLine("Danh sach quyen sach tang dan theo gia: ");

        List<Book> sortByPrice = listBook.OrderBy(book => book.Price).ToList();

        foreach(Book b in sortByPrice)
        {
            Console.WriteLine(b);
        }

        //tìm kiếm theo title
        Console.Write("Nhập Title can tim kiem: ");
        string title = Console.ReadLine();

        Console.WriteLine("\n\nDanh sach can tim: ");
        foreach (Book b in listBook)
        {
            if(String.Compare(title, b.Title, true) == 0)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine("Khong tim thay quyen sach co title tren");
            }
        }

        //nhung quyen sach xuat ban nam 2014
        Console.WriteLine("\n\nNhung quyen sach xuat ban nam 2014: ");
        foreach (Book b in listBook)
        {
            if (b.Year == 2014)
            {
                Console.WriteLine(b);
            }
        }

        //xóa sách của nhà xuất ban Kim Dong
        Console.WriteLine("Nhap nha xuat ban ban muon xoa: ");
        string publisherDelete = Console.ReadLine();
        int bookRemoved = listBook.RemoveAll(book => string.Compare(book.Publisher, publisherDelete, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase) == 0);
        Console.WriteLine($"Da xoa {bookRemoved} quyen sach cua nha xuat ban {publisherDelete}");
        Console.WriteLine("Danh sách sau khi đã xóa: ");
        foreach (Book b in sortByPrice)
        {
            Console.WriteLine(b);
        }
    }
}
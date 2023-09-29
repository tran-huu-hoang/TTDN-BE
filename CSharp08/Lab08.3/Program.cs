using Lab08._3;
using System.Text;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[] number = { 8, 9, 4, 7, 3, 6, 2, 1, 5, 0, 5, 6, 9, 3 };
        string[] word = { "yasuo", "zed", "yi", "ashe", "vayne", "kaisa", "ziggs", "yone", "sett", "camile", "kayle", "jax", "zeri", "taliyah", "zed" };

        List<Film> listFilm = new List<Film>()
        {
            new Film{FilmId = "F01", FilmName = "Titanic", Price = 1000},
            new Film{FilmId = "F02", FilmName = "Ironman", Price = 2000},
            new Film{FilmId = "F03", FilmName = "Batman", Price = 6000},
            new Film{FilmId = "F04", FilmName = "Avenger", Price = 1300},
            new Film{FilmId = "F05", FilmName = "Spiderman", Price = 5600},
            new Film{FilmId = "F06", FilmName = "Black Panther", Price = 8400},
            new Film{FilmId = "F07", FilmName = "Superman", Price = 9200},
            new Film{FilmId = "F08", FilmName = "Captain America", Price = 1800},
        };

        //lọc các số chẵn
        IEnumerable<int> querynumber = number.Where(n => n % 2 == 0);
        Console.WriteLine("Lọc các số chẵn: ");
        foreach (var query in querynumber)
        {
            Console.Write(query + "\t");
        }

        //lọc các từ có độ dài > 4
        IEnumerable<string> queryword = word.Where(w => w.Length > 4);
        Console.WriteLine("\n\nLọc các từ có độ dài > 4: ");
        foreach (var query in queryword)
        {
            Console.Write(query + "\t");
        }

        //lọc các từ có tên bắt đầu bằng chữ t
        IEnumerable<string> queryT = word.Where(w => w.StartsWith("t"));
        Console.WriteLine("\n\nLọc các từ bắt đầu t: ");
        foreach (var query in queryT)
        {
            Console.Write(query + "\t");
        }

        //lọc các số là duy nhất trong mảng
        var uniqueNumber = number.Distinct();
        Console.WriteLine("\n\nLọc các số là duy nhất trong mảng: ");
        foreach (var query in uniqueNumber)
        {
            Console.Write(query + "\t");
        }

        //đếm số từ không trùng nhau
        var countDistinct = word.Distinct().Count();
        Console.WriteLine("\n\nSố từ không trùng nhau: " + countDistinct);

        //lấy 4 số đầu trong mảng
        var fourNumber = number.Take(4);
        Console.WriteLine("\n\nLấy 4 số đầu trong mảng: ");
        foreach (var query in fourNumber)
        {
            Console.Write(query + "\t");
        }

        //lấy 4 từ đầu trong mảng
        var fourWord = word.Take(4);
        Console.WriteLine("\n\nLấy 4 từ đầu trong mảng: ");
        foreach (var query in fourWord)
        {
            Console.Write(query + "\t");
        }

        //lấy những từ đầu tiên có chứa chữ t:
        IEnumerable<string> searchword = word.Where(w => w.Contains("t"));
        Console.WriteLine("\n\nLấy những từ đầu tiên có chứa chữ t: ");
        foreach (var query in searchword)
        {
            Console.Write(query + "\t");
        }

        //sắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 2000
        var queryFilm = listFilm.OrderBy(f => f.Price).Select(x => new {x.FilmId, x.FilmName, x.Price}).ToList().TakeWhile(f => f.Price < 2000);
        Console.WriteLine("\n\nSắp xếp theo đơn giá, lấy những phim đầu tiên có đơn giá < 2000: ");
        foreach (var query in queryFilm)
        {
            Console.WriteLine(query);
        }

        //bỏ qua 3 phần từ đầu tiên, lấy 4 phần tử tiếp
        IEnumerable<int> skipNumber = number.Skip(3).Take(4);
        Console.WriteLine("\n\nBỏ qua 3 phần từ đầu tiên, lấy 4 phần tử tiếp: ");
        foreach (var query in skipNumber)
        {
            Console.Write(query + "\t");
        }
    }
}
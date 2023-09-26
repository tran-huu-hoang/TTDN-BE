using Lab06_ex6._3;
using System.Collections;
using System.Globalization;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Car> listCar = new List<Car>()
        {
            new Car{name = "Porche", color = "Black"},
            new Car{name = "Audi", color = "Red"},
            new Car{name = "Maserati", color = "Pink"},
            new Car{name = "Lamborghini", color = "Blue"},
            new Car{name = "Ferrari", color = "Gray"},
            new Car{name = "MCLaren", color = "Orange"},
            new Car{name = "Pagani", color = "Dark"},
            new Car{name = "Bugatti", color = "Green"},
            new Car{name = "Koenigsegg", color = "Violet"},
            new Car{name = "Bentley", color = "Black"},
        };

        Console.WriteLine("Danh sach xe: ");
        foreach (var car in listCar)
        {
            Console.WriteLine("\nName: " + car.name + "\nColor: " + car.color);
        }

        //xóa xe theo màu
        Console.Write("Nhập màu xe muốn xóa: ");
        string ColorDelete = Console.ReadLine();
        int CarRemoved = listCar.RemoveAll(car => string.Compare(car.color, ColorDelete, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | System.Globalization.CompareOptions.IgnoreCase) == 0);
        Console.WriteLine($"Da xoa {CarRemoved} xe co mau {ColorDelete}");
        Console.WriteLine("Danh sách xe sau khi đã xóa: ");
        foreach (var car in listCar)
        {
            Console.WriteLine("\nName: " + car.name + "\nColor: " + car.color);
        }
    }
}
using Lab04._3;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Circle circle = new Circle();
        circle.InputData();
        Console.WriteLine("Chu vi và diện tích hình tròn: {0}; {1}", circle.Area(), circle.Cirumference());

        Rectangle rectangle = new Rectangle();
        rectangle.InputData();
        Console.WriteLine("Chu vi và diện tích hình chữ nhật: {0}; {1}", rectangle.Area(), rectangle.Cirumference());
    }
}
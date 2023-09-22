using Lab04_exx4._4;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Faculty faculty = new Faculty("hoang", "0123456789", "hoang@gmail.com", "Kế toán", 1000, 2500, "challenge");

        faculty.Display();
    }
}
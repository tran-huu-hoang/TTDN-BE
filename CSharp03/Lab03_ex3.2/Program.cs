using Lab03_ex3._2;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Book book = new Book("hoang", 12, "asb", "hoang");
        book.FlipPageBackward();
        book.FlipPageBackward();
        book.FlipPageBackward();
        book.FlipPageForward();
        book.FlipPageBackward();
        book.FlipPageForward();
    }
}
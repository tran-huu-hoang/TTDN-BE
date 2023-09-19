using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập một kí tự: ");
        char a = Convert.ToChar(Console.ReadLine());

        switch (a)
        {
            case 'a': Console.WriteLine("Đây là nguyên âm");
                break;
            case 'u':
                Console.WriteLine("Đây là nguyên âm");
                break;
            case '0':
                Console.WriteLine("Đây là nguyên âm");
                break;
            case 'e':
                Console.WriteLine("Đây là nguyên âm");
                break;
            case 'i':
                Console.WriteLine("Đây là nguyên âm");
                break;
            default: Console.WriteLine("Đây là phụ âm");
                break;
        }
    }
}
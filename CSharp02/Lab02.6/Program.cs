using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string[] name = {"hoàng", "vip", "pro", "v" };

        foreach(string s in name)
        {
            Console.Write(s + " ");
        }
    }
}
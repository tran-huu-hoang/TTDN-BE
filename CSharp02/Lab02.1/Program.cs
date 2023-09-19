using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập số thuê bao: ");
        string name = Console.ReadLine();
        Console.Write("Nhập số điện: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double money;

        if(number <= 30)
        {
            money = 30;
        }
        else if(number >30 && number <= 50)
        {
            money = 30 + (number - 30) * 1.2;
        }
        else
        {
            money = 30 + 20 * 1.2 + (number - 50) * 1.5;
        }

        Console.WriteLine("----Thông tin thuê bao----");
        Console.WriteLine("Số thuê bao: " + name);
        Console.WriteLine("Số điện: " + number);
        Console.WriteLine("Số tiền điện: " + money + "$");
    }
}
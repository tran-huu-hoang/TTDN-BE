using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Nhập tháng: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhập năm: ");
        int year = Convert.ToInt32(Console.ReadLine());

        switch(month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("Tháng này có 31 ngày");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("Tháng này có 30 ngày");
                break;
            case 2:
                if(year % 4 == 0)
                {
                    Console.WriteLine("Tháng này có 29 ngày");
                }
                else
                {
                    Console.WriteLine("Tháng này có 28 ngày");
                }
                break;
            default:
                Console.WriteLine("Vui lòng nhập tháng từ 1-12");
                break;
        }
    }
}
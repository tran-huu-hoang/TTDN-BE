using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        double tien_gui, lai_suat_nam;
        int month;

        Console.Write("Nhập số tiền gửi: ");
        tien_gui = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập lãi suất theo năm: ");
        lai_suat_nam = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập số tháng gửi: ");
        month = Convert.ToInt32(Console.ReadLine());

        double lai_suat_thang = (lai_suat_nam / 12) / (double)100;
        double so_du = tien_gui;

        for(int i=0; i<month; i++)
        {
            so_du = so_du + so_du * lai_suat_thang;
        }

        Console.WriteLine("Số dư cuối kì là: " + so_du);
        Console.WriteLine("Tiền lãi cuối kì là: " + (so_du - tien_gui));

    }
}
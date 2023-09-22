using Lab04_ex4._1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        //không mất phí giao dịch
        Console.Write("Nhập số tiền ban đầu: ");
        double initialize = Convert.ToDouble(Console.ReadLine());

        //tạo tài khoản
        Account acc = new Account(initialize);

        //gửi tiền
        Console.Write("Nhập số tiền cần gửi: ");
        double deposit = Convert.ToDouble(Console.ReadLine());
        acc.Deposit(deposit);
        Console.WriteLine("Số dư: " + acc.GetBalance());

        //rut tiền
        Console.Write("Nhập số tiền cần rút: ");
        double widthdraw = Convert.ToDouble(Console.ReadLine());
        acc.WithDrawing(widthdraw);
        Console.WriteLine("Số dư: " + acc.GetBalance());


        //có mất phí giao dịch
        Console.Write("Nhập số tiền ban đầu: ");
        double initialize2 = Convert.ToDouble(Console.ReadLine());

        //tạo tài khoản
        CheckAccount acc2 = new CheckAccount(initialize2, 10);

        //gửi tiền
        Console.Write("Nhập số tiền cần gửi: ");
        double deposit2 = Convert.ToDouble(Console.ReadLine());
        acc2.Deposit(deposit2);
        Console.WriteLine("Số dư: " + acc2.GetBalance());

        //rut tiền
        Console.Write("Nhập số tiền cần rút: ");
        double widthdraw2 = Convert.ToDouble(Console.ReadLine());
        acc2.WithDrawing(widthdraw2);
        Console.WriteLine("Số dư: " + acc2.GetBalance());
    }
}
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string id = "NV01";
        string name = "Nguyen Van A";
        DateOnly dateOfBirth = new DateOnly(2000, 02, 01);
        string address = "Ha Noi";
        string phone = "0123456789";
        string email = "nguyenvana@gmail.com";

        Console.WriteLine("Mã nhân vien: " + id);
        Console.WriteLine("Ten nhan vien: " + name);
        Console.WriteLine("Ngay sinh: " + dateOfBirth);
        Console.WriteLine("Dia chi: " + address);
        Console.WriteLine("Dien thoai: " + phone);
        Console.WriteLine("Email: " + email);
    }
}
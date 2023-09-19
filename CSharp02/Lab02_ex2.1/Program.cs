using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string id, name, address;
        double salary, bonus, totalSalary;
        DateTime birthDay;

        Console.Write("Nhập mã: ");
        id = Console.ReadLine();
        Console.Write("Nhập tên: ");
        name = Console.ReadLine();
        Console.Write("Nhập địa chỉ: ");
        address = Console.ReadLine();
        Console.Write("Nhập ngày sinh: ");
        birthDay = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Nhập tiền lương: ");
        salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập tiền thưởng: ");
        bonus = Convert.ToDouble(Console.ReadLine());

        totalSalary = salary + bonus;

        Console.WriteLine("Mã nhân viên: " + id);
        Console.WriteLine("Tên: " + name);
        Console.WriteLine("Địa chỉ: " + address);
        Console.WriteLine("Ngày sinh: " + birthDay.ToString("dd/MM/yyyy"));
        Console.WriteLine("Tiền lương: " + salary);
        Console.WriteLine("Tiền thưởng: " + bonus);
        Console.WriteLine("Tổng lương: " + totalSalary);
    }
}
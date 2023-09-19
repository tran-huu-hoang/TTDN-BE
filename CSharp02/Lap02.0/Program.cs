using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string id, name;
        double mark1, mark2, mark3, average;
        DateTime dataOfBirth;

        Console.Write("Nhập mã số: ");
        id = Console.ReadLine();
        Console.Write("Nhập tên: ");
        name = Console.ReadLine();
        Console.Write("Nhập ngày sinh: ");
        dataOfBirth = Convert.ToDateTime(Console.ReadLine());
        Console.Write("Nhập điểm thứ 1: ");
        mark1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập điểm thứ 2: ");
        mark2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập điểm thứ 3: ");
        mark3 = Convert.ToDouble(Console.ReadLine());

        average = (mark1 + mark2 + mark3) / 3;

        Console.WriteLine("-----Thông tin sinh viên-----");
        Console.WriteLine("Mã số: " + id);
        Console.WriteLine("Tên: " + name);
        Console.WriteLine("Ngày sinh: " + dataOfBirth.ToString("dd/MM/yyyy"));
        Console.WriteLine("Điểm thứ 1: " + mark1);
        Console.WriteLine("Điểm thứ 2: " + mark2);
        Console.WriteLine("Điểm thứ 3: " + mark3);
        Console.WriteLine("Điểm trung bình: " + average);
    }
}
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string kq = "";
        int year;
        Console.Write("Nhập năm: ");
        year = int.Parse(Console.ReadLine());

        string[] Can = { "Canh", "Tân", "Nhâm", "Quý", "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ" };
        string[] Chi = { "Thân", "Dậu", "Tuất", "Hợi", "Tý", "Sửu", "Dần", "Mão", "Thìn", "Tỵ", "Ngọ", "Mùi" };

        int can, chi;
        can = year % 10;
        chi = year % 12;

        kq = Can[can] + " " + Chi[chi];

        Console.WriteLine("Năm {0} là năm " + kq, year);
    }
}
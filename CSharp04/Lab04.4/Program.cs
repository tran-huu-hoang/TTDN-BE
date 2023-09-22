using Lab04._4;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Iperson staff = new Staff();

        staff.Insert("Hoang");
        staff.Delete("Vip");
        staff.Update("pro");
        staff.Display("max");

        Iperson student = new Student() { Id = "SV1", Name = "Hoàng", Age = 20};
        student.Display(student);
    }
}
using Lab05._3;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        Student st = new Student(3, 2);
        st[0] = "hoang";
        st[0, 0] = 9;
        st[0, 1] = 10;

        st[1] = "vip";
        st[1, 0] = 8;
        st[1, 1] = 7;

        st[2] = "pro";
        st[2, 0] = 6;
        st[2, 1] = 7;

        Console.WriteLine("Thong tin sinh vien");
        for (int i = 0; i < 3; i++)
{
            Console.WriteLine("Ho va ten: "+ st[i]);
            Console.Write("Diem: ");
            for (int j = 0; j < 2; j++)
{
                Console.Write(st[i, j] + ",");
            }
            Console.WriteLine();
        }
    }
}
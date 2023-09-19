using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        double a, b, c, delta, x1, x2;

        do
        {
            Console.Write("Nhập a: ");
            a = Convert.ToDouble(Console.ReadLine());
        } while (a == 0);

        Console.Write("Nhập b: ");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Nhập c: ");
        c = Convert.ToDouble(Console.ReadLine());

        delta = b * b - 4 * a * c;

        if(delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm");
        }
        else if(delta == 0)
        {
            Console.WriteLine("Phương trình có nghiệm kép x = " + (-b / (2 * a)));
        }
        else
        {
            x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Phương trình có hai nghiệm phân biệt là: x1 = {0}, x2 = {1} ", x1, x2);
        }
    }
}
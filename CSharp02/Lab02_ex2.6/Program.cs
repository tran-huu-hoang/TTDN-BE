using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        double a, b, c;

        do
        {
            Console.Write("Nhập cạnh a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập cạnh c: ");
            c = Convert.ToDouble(Console.ReadLine());
        } while (a<=0 || b <= 0 || c <= 0);

        if(a+b > c && a+c > b && b+c > a)
        {
            if(a == b && a == c && b == c)
            {
                Console.WriteLine("Đây là ba cạnh của tam giác đều");
            }
            else if(a == b || a == c ||  c == b)
            {
                Console.WriteLine("Đây là ba cạnh của tam giác cân");
            }
            if(a*a + b*b == c*c || a*a + c*c == b*b || b*b + c*c == a * a)
            {
                Console.WriteLine("Đây là ba cạnh của tam giác vuông");
            }
        }
        else
        {
            Console.WriteLine("Đây không phải 3 cạnh của một tam giác");
        }
    }
}
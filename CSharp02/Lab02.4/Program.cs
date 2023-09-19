using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Các số nguyên tố từ 2-100");

        bool check_i;
        for(int i = 2; i <= 100; i++)
        {
            check_i = true;
            for(int j=2; j < i; j++)
            {
                if(i%j == 0)
                {
                    check_i = false;
                    break;
                }
            }
            if (check_i)
            {
                Console.Write(i + " ");
            }
        }
    }
}
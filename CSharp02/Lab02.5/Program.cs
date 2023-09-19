using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Tổng các số chẵn chia hết cho 3 từ 1-100");

        int tong = 0;

        for(int i=1; i<=100; i++)
        {
            if(i %2 ==0 && i%3 != 0)
            {
                tong += i;
            }
        }
        Console.WriteLine(tong);
    }
}
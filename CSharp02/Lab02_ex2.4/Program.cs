using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Các số có tổng các chữ số là số chẵn từ 100-999");

        int tram, chuc, donvi;

        for(int i = 100; i <= 999; i++)
        {
            tram = i / 100;
            chuc = (i - tram*100)/10;
            donvi = i- tram*100 - chuc*10;
            if((tram+chuc+donvi) % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
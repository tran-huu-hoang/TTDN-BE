using static Lab07._4.Custom;

internal class Program
{
    private static void Main(string[] args)
    {
        int intNum = 0;
        Console.Write("Nhap 1 so: ");

        try
        {
            intNum = Convert.ToInt32(Console.ReadLine());
            if(intNum <= 0)
            {
                throw new InvalidInputNumber();
            }
        }
        catch(InvalidInputNumber e)
        {
            Console.WriteLine(e.Message);
        }
        catch(System.FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            if(intNum > 0)
            {
                for(int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i * intNum);
                }
            }
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        for (int i = 1; i < 10; i ++)
        {
            for (int j = i; j < 10; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write(j+1);
            }

            for (int j = i-1; j >0; j--)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }
    }
}
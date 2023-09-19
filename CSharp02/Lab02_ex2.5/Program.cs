internal class Program
{
    private static void Main(string[] args)
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j < i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for (int i = 10; i >0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        for(int i = 1; i <10; i+=2)
        {
            for (int j = i; j < 10; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
        }
    }
}
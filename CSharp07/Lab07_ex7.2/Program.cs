internal class Program
{
    private static void Main(string[] args)
    {
        byte[] arr = new byte[5];

        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToByte(Console.ReadLine());
            }
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine("Loi vuot qua pham vi cua mang");
        }

        Console.WriteLine("Mang: ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(arr[i] + "\t");
        }
    }
}
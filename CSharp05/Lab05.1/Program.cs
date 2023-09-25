internal class Program
{
    private static void Main(string[] args)
    {
        int[] m = {1, 2, 3, 4, 5, 9, 10 };

        Console.WriteLine("Các phần tử của mảng: ");
        for(int i = 0; i < m.Length; i++)
        {
            Console.Write(m[i] + "\t");
        }

        int max = m[0];
        for(int i = 1; i < m.Length;  ++i)
        {
            if (m[i] > max)
            {
                max = m[i];
            }
        }
        Console.WriteLine("\nMax: " + max);

        //kiểm tra mảng có đối xứng ko
        bool check = true;
        for(int i = 0;i < m.Length; ++i)
        {
            if (m[i] != m[m.Length - 1 - i])
            {
                check = false;
                break;
            }
        }
        if (check)
        {
            Console.WriteLine("Mảng đối xứng");
        }
        else
        {
            Console.WriteLine("Mảng không đối xứng");
        }
    }
}
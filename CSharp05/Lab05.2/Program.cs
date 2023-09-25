internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr = {{ 4, 7, 2 }, { 2, 4, 5}, {1, 6, 9 } };

        //duyệt mảng và in theo cột
        Console.WriteLine("Mảng: ");
        for(int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for(int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }

        //chỉ số hàng = chỉ số cột
        Console.WriteLine("Hàng = cột: ");
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if(i == j)
                {
                    Console.Write("{0} \t", arr[i, j]);
                }
            }
            Console.WriteLine();
        }

        //các phần tử lớn nhất trên hàng
        Console.WriteLine("Các phần tử lớn nhất trên hàng: ");

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            int max = arr[i, 0];
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                }
            }
            Console.WriteLine("Hàng {0}: {1}", i, max);
        }
    }
}
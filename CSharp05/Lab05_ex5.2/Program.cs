internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr = { { 5, 2, 8, 5 }, { 7, 3, 9, 1 }, { 4, 6, 12, 9 }, { 3, 9, 7, 4 } };

        Console.WriteLine("Mảng ban đầu: ");
        for(int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for(int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                Console.Write(arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int tong = 0;

        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if (i == j)
                {
                    tong += arr[i, j];
                }
            }
        }
        Console.WriteLine("\nTổng các phần tử có chỉ số hàng = cột: " + tong);

        Console.WriteLine("\n\nCác phần tử nhỏ nhất trên cột: ");
        for (int i = 0; i <= arr.GetUpperBound(1); i++)
        {
            int min = arr[0, i];
            for (int j = 0; j <= arr.GetUpperBound(0); j++)
            {
                if (arr[j, i] < min)
                {
                    min = arr[j, i];
                }
            }
            Console.WriteLine("Cột {0}: {1}", i, min);
        }

        Console.WriteLine("\n\nCác phần tử chia hết cho 7: ");
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if (arr[i, j] % 7 ==0)
                {
                    Console.Write(arr[i, j] + "\t");
                }
            }
        }

        int tongVien = 0;
        for (int i = 0; i <= arr.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= arr.GetUpperBound(1); j++)
            {
                if(i == 0 || j == 0 || i == arr.GetUpperBound(0) || j == arr.GetUpperBound(1))
                {
                    tongVien += arr[i, j];
                }
            }
        }
        Console.WriteLine("\n\nTồng các phần tử ở viền là: " + tongVien);

        static int[] Array1(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);
            int length = row * col;
            int index = 0;

            int[] array = new int[length];
            for(int  i = 0; i <= row; i++)
            {
                for(int j = 0; j <= col; j++)
                {
                    array[index] = arr[i, j];
                    index++;
                }
            }
            Array.Sort(array);
            return array;
        }

        for(int i=0; i < Array1(arr).Length; i++)
        {
            Console.WriteLine(Array1(arr)[i]);
        }
    }
}
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[] arr = {1, -2, 3, -4, 6, 8, -9, 12, 14, 17};

        Console.WriteLine("Mảng ban đầu: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }

        int min = arr[0];
        Console.Write("\n\nMin: ");
        for (int i = 0; i < arr.Length; i++)
        {
            if(min > arr[i])
            {
                min = arr[i];
            }
        }
        Console.Write(min + "\n\n");

        int tg;
        for(int i = 0; i < (arr.Length - 1) / 2; i++)
        {
            tg = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = tg;
        }

        Console.WriteLine("Mảng đã đảo ngược: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }

        int tgT;
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for(int j = i + 1; j< arr.Length; j++)
            {
                if (arr[i] < arr[j])
                {
                    tgT = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tgT;
                }
            }
        }
        Console.WriteLine("\n\nMảng giảm: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }

        Console.WriteLine("Cac phan tu trong mang la so nguyen to la: ");
        for (int i = 0; i < arr.Length; i++)
        {
            bool check = true;
            for (int j = 2; j <= arr[i] / 2; j++)
            {
                if (arr[i] % j == 0)
                {
                    check = false;
                }
            }
            if (arr[i] > 0 && check)
            {
                Console.Write(arr[i] + " ");
            }
        }
        Console.WriteLine();

        int tbc = 0;
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                tbc += arr[i];
                index++;
            }
        }
        Console.WriteLine("trung binh cong cac phan tu duong trong mang la: " + (tbc / index));

        bool am = false;
        bool duong = false;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                duong = true;
            }
            if (arr[i] < 0)
            {
                am = true;
            }
        }
        if (am && duong)
        {
            Console.WriteLine("Mang chua cac phan tu am va duong");

        }
        else if (duong)
        {
            Console.WriteLine("Mang chi chua cac duong");
        }
        else { Console.WriteLine("Mang chi chua cac am"); }
    }
}
}
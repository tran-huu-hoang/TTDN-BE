internal class Program
{
    private static void Main(string[] args)
    {
        byte[] arr = new byte[5];

        //nhap mang
        try
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("arr[{0}] = ", i);
                arr[i] = Convert.ToByte(Console.ReadLine());
            }
        }
        catch(FormatException ex)
        {
            Console.WriteLine("Khong duoc nhap ki tu");
        }
        catch(OverflowException ex)
        {
            Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
        }
        catch(IndexOutOfRangeException ex)
        {
            Console.WriteLine("Loi vuot qua pham vi cua mang");
        }

        Console.WriteLine("Mang: ");
        for(int i = 0;i < 5; i++)
        {
            Console.Write(arr[i] + "\t");
        }
    }
}
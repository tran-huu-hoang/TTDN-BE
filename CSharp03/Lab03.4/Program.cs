using Lab03._4;

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 20, b = 30;
        double area;

        Utility u= new Utility();
        Console.WriteLine("Truoc khi hoan vi: a={0}, b={1}", a, b);
        u.FakeSwap(a, b);
        Console.WriteLine("Sau khi hoan vi fake: a={0}, b={1}", a, b);
        u.RealSwap(ref a, ref b);
        Console.WriteLine("Sau khi hoan vi real: a={0}, b={1}", a, b);
        u.AreaCircle(100, out area);
        Console.WriteLine("Chu vi hinh tron ban kinh 100 la: {0}", area);
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        string[] data = {"yasuo", "zed", "yi", "ashe", "vayne", "kaisa", "ziggs", "yone", "sett", "camile", "kayle", "jax", "zeri"};

        IEnumerable<string> result1 = from m in data select m;

        Console.WriteLine("Hien thi tat ca ket qua: ");
        foreach(var item in result1)
        {
            Console.Write(item + "\t");
        }

        //truy van co dieu kien
        IEnumerable<string> result2 = from m in data where m.Equals("yi") select m;
        Console.WriteLine("\n\nTruy van theo dieu kien: ");
        foreach(var item in result2)
        {
            Console.Write(item + "\t");
        }

        //sap xep du lieu
        IEnumerable<string> result3 = from m in data orderby m select m;
        Console.WriteLine("\n\nKet qua sau khi da sap xep: ");
        foreach (var item in result3)
        {
            Console.Write(item + "\t");
        }

        //lay du lieu moi
        var result4 = from m in data select new { Thuong = m.ToLower(), Hoa = m.ToUpper() };
        Console.WriteLine("\n\nChu thuong va chu hoa: ");
        foreach( var item in result4)
        {
            Console.WriteLine(item.Thuong + ":" + item.Hoa);
        }
    }
}
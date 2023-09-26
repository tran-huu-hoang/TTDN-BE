using Lab06._1;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        ArrayList arrayList = new ArrayList();

        arrayList.Add(new Product("A", 5.9, 3));
        arrayList.Add(new Product("B", 8.2, 2));
        arrayList.Add(new Product("C", 4.7, 4));
        arrayList.Add(new Product("D", 9.6, 5));

        Console.WriteLine("Danh sách phần tử: ");
        foreach(Product product in arrayList)
        {
            Console.WriteLine(product + "\t");
        }
    }
}
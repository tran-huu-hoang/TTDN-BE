using Lab08._2;

internal class Program
{
    private static void Main(string[] args)
    {
        var customer = new Customer[]
        {
            new Customer {Id = 1, Name = "Sam" },
            new Customer {Id = 2, Name = "So" },
            new Customer {Id = 3, Name = "Sau" },
            new Customer {Id = 4, Name = "Su" },
        };

        var order = new Order[]
        {
            new Order {Id = 1, Product = "TV"},
            new Order {Id = 2, Product = "TL"},
            new Order {Id = 3, Product = "DH"},
            new Order {Id = 4, Product = "MG"},
        };

        var query = from c in customer join o in order on c.Id equals o.Id select new { c.Name, o.Product };

        foreach(var item in query)
        {
            Console.WriteLine("{0} bought {1}", item.Name, item.Product);
        }
    }
}
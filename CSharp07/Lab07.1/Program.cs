using Lab07._1;

internal class Program
{
    private static void Main(string[] args)
    {
        //tao moi nha phan phoi cung cap day du namespace
        Supply.Manufacturer dealer = new Supply.Manufacturer();

        dealer.Name = "Da qua pepsi oi";
        dealer.Email = "pesi@gmail.com";
        dealer.Phone = "1234567890";

        Console.WriteLine("Dealer Infomation: ");
        Console.WriteLine("\tName: " + dealer.Name);
        Console.WriteLine("\tEmail: " + dealer.Email);
        Console.WriteLine("\tPhone: " + dealer.Phone);

        //tao moi san pham trong namespace store
        StoreItem wholeSale = new StoreItem();

        wholeSale.ItemNo = 1;
        wholeSale.ItemName = "cocacola";
        wholeSale.Price = 10000;

        Console.WriteLine("Store Invetory: ");
        Console.WriteLine("\tItem #: " + wholeSale.ItemNo);
        Console.WriteLine("\tItem Name: " + wholeSale.ItemName);
        Console.WriteLine("\tItem Price: " + wholeSale.Price);
    }
}
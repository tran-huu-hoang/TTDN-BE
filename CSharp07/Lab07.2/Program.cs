internal class Program
{
    private static void Main(string[] args)
    {
        Business.House house = new Business.House();

        house.HouseNo = "s1";
        house.Price = 100;

        Console.WriteLine("House Details: ");
        Console.WriteLine("\tHouse #: " + house.HouseNo);
        Console.WriteLine("\tHouse Price: " + house.Price);

        Business.DealerShip.Car car = new Business.DealerShip.Car();

        car.CarNo = "c1";
        car.Price = 200;

        Console.WriteLine("Car Details: ");
        Console.WriteLine("\tCar #: " + car.CarNo);
        Console.WriteLine("\tCar Price: " + car.Price);
    }
}
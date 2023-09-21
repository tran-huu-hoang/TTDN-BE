using Lab03._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Car();

        car.make = "May bach";
        car.model = "S200";
        car.color = "black";
        car.year = "2000";

        Console.WriteLine("Make: " + car.make);
        Console.WriteLine("Model: " + car.model);
        Console.WriteLine("Color: " + car.color);
        Console.WriteLine("Year: " + car.year);

        car.Start();
        car.Stop();
    }
}
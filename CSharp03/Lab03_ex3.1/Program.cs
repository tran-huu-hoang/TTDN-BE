using Lab03_ex3._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Employee employee1 = new Employee(1, "nguyen van a", 2003, 2, 10000);
        Employee employee2 = new Employee(2, "nguyen van b", 2003, 1, 10000);
        Employee employee3 = new Employee(3, "nguyen van c", 2003, 3, 10000);

        employee1.Display();
        employee2.Display();
        employee3.Display();
    }
}
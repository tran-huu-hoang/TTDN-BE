using Lab05_ex5._4;

internal class Program
{
    private static void Main(string[] args)
    {
        Department department = new Department("Hoang vippro", 3);

        Employee employee1 = new Employee(1, "hoang1", 9);
        Employee employee2 = new Employee(2, "hoang2", 18);
        Employee employee3 = new Employee(2, "hoang2", 18);

        department[0] = employee1;
        department[1] = employee2;
        department[2] = employee3;

        Console.WriteLine("Details: ");
        for(int i=0;  i<3; i++)
        {
            Console.WriteLine("Employee: {0}", i + 1);
            department[i].Display();
            Console.WriteLine();
        }
    }
}
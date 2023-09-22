using Lab04._2;

internal class Program
{
    private static void Main(string[] args)
    {
        StudentCollege s1 = new StudentCollege("hoang", 2003, 9, 10, 9);
        s1.Display();
        Console.WriteLine("Diem trung binh cua s1: " + s1.Average());

        StudentUniversity s2 = new StudentUniversity("hoang", 2003, 9, 10, 9, 8);
        s2.Display();
        Console.WriteLine("Diem trung binh cua s2: " + s2.Average());
    }
}
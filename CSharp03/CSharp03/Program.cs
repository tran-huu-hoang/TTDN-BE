using CSharp03;

internal class Program
{
    private static void Main(string[] args)
    {
        //Tạo đối tượng
        Student student = new Student("s1", "hoang", "123", "Gmail");

        //Gán đối tượng
        //student.Id = "SV01";
        //student.Name = "Hoang";
        //student.Phone = "0123456789";
        //student.Email = "Hoang@gmail.com";

        Console.WriteLine(student.Id);
        Console.WriteLine(student.Name);
        Console.WriteLine(student.Phone);
        Console.WriteLine(student.Email);
    }
}
using Lab07_ex7._3;
using System.Text;
using static Lab07_ex7._3.Custom;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Student student = new Student();

        try
        {
            student.Nhap();
            if(student.Theorymark < 0 ||  student.Theorymark > 10 || student.Labmark < 0 || student.Labmark > 10)
            {
                throw new InvalidMarkException();
            }
        }
        catch (InvalidMarkException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (student.Theorymark >= 0 && student.Theorymark <= 10 && student.Labmark >= 0 && student.Labmark <= 10)
            {
                student.In();
            }
        }
    }
}
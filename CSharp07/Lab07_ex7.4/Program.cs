using Lab07_ex7._4;
using System.Text;
using static Lab07_ex7._4.Custom;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Lecture lecture = new Lecture();

        try
        {
            lecture.Nhap();
            if (lecture.Salary < 60000 || lecture.Bonus > 10000)
            {
                throw new AmountException();
            }
        }
        catch (AmountException ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            if (lecture.Salary >= 60000 && lecture.Bonus <= 10000)
            {
                lecture.In();
            }
        }
    }
}
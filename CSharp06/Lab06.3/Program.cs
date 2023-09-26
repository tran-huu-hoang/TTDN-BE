using Lab06._3;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        List<Student> students = new List<Student>()
        {
            new Student{Id = "S01", FirstName = "Tran", LastName = "Hoang", Gender = true, Avg = 9},
            new Student{Id = "S02", FirstName = "Ly", LastName = "Cuong", Gender = true, Avg = 8},
            new Student{Id = "S03", FirstName = "Nguyen", LastName = "Linh", Gender = false, Avg = 5},
            new Student{Id = "S04", FirstName = "Bui", LastName = "Khanh", Gender = true, Avg = 8.5},
            new Student{Id = "S05", FirstName = "Le", LastName = "Anh", Gender = false, Avg = 7},
            new Student{Id = "S06", FirstName = "Pham", LastName = "Quy", Gender = true, Avg = 8},
            new Student{Id = "S07", FirstName = "Quach", LastName = "Duc", Gender = true, Avg = 6},
        };

        Console.WriteLine("Danh sách sinh viên: ");
        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }

        //tìm sinh viên có điểm trung bình cao nhất
        double maxAvg = students[0].Avg;
        Student stmax = students[0];

        foreach(Student student in students)
        {
            if(maxAvg < student.Avg)
            {
                maxAvg = student.Avg;
                stmax = student;
            }
        }

        Console.WriteLine("\n\nSinh viên có điểm TB cao nhất: " + stmax);
    }
}
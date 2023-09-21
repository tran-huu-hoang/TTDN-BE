using Lab03._3;

internal class Program
{
    private static void Main(string[] args)
    {
        StudentModel student = new StudentModel();

        List<Student> list = student.Getstudent();
        foreach(var item in list)
        {
            item.Display();
        }

        //theo id
        Student st = student.Getstudent(2);
        st.Display();

        //theo tuổi
        List<Student> listage = student.Getstudent(14, 20);
        foreach (var item in listage)
        {
            item.Display();
        }
    }
}
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        SortedList<int, string> dayList = new SortedList<int, string>();
        dayList.Add(1, "Monday");
        dayList.Add(2, "Tuesday");
        dayList.Add(3, "Wednessday");
        dayList.Add(4, "Thurday");
        dayList.Add(5, "Friday");
        dayList.Add(6, "Saturday");
        dayList.Add(7, "Sunday");

        Console.WriteLine("Các ngày trong tuần: ");
        foreach (int i in dayList.Keys)
        {
            Console.WriteLine(i + ": " + dayList[i]);
        }

        //tìm ngày tuesday và thông báo
        if (dayList.ContainsValue("Tuesday"))
        {
            Console.WriteLine("Tìm thấy Tuesday");
        }
        else
        {
            Console.WriteLine("Không tìm thấy Tuesday");
        }
    }
}
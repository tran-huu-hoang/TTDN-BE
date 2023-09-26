internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<string, string> listEm = new SortedList<string, string>();

        listEm.Add("S01", "hoang");
        listEm.Add("S02", "a");
        listEm.Add("S03", "b");
        listEm.Add("S04", "c");
        listEm.Add("S05", "d");

        Console.WriteLine("Danh sách:");
        foreach(var key in listEm.Keys)
        {
            Console.WriteLine(key + ":" + listEm[key]);
        }

        Console.WriteLine("Danh sách nhân viên bắt đầu bằng chữ h: ");
        foreach (var key in listEm.Keys)
        {
            if (listEm[key].StartsWith("h"))
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
        }

        //xóa nhân viên có mã S03 và in lại ra danh sách
        listEm.Remove("S03");
        Console.WriteLine("Danh sách:");
        foreach (var key in listEm.Keys)
        {
            Console.WriteLine(key + ":" + listEm[key]);
        }
    }
}
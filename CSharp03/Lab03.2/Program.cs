using Lab03._2;

internal class Program
{
    private static void Main(string[] args)
    {
        Contact contact1 = new Contact();
        contact1.Id = 1;
        contact1.Firstname = "Test";
        contact1.Lastname = "Test";
        contact1.Address = "Hanoi";
        contact1.Phone = "1234567890";
        contact1.Email = "gmail";
        contact1.Display();


        Contact contact2 = new Contact(1, "Nguyen", "Van A", "hc,", "3210", "email");
        contact2.Display();
    }
}
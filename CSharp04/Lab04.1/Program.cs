using Lab04._1;

internal class Program
{
    private static void Main(string[] args)
    {
        Window wd = new Window(1, 2);

        ListBox listBox = new ListBox(3, 4, "Hoangvippro");

        Button btn = new Button(5, 6);

        wd.DrawWindow();
        listBox.DrawWindow();
        btn.DrawWindow();

        //mang window
        Window[] winArr = new Window[3];
        winArr[0] = new Window(7, 8);
        winArr[1] = new ListBox(9, 10, "promax");
        winArr[2] = new Button(11, 12);

        for (int i = 0; i < 3; i++)
        {
            winArr[i].DrawWindow();
        }
    }
}
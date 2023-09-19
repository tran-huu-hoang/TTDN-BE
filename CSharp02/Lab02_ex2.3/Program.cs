using System.Text;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int number;

        do
        {
            Console.Write("Nhập số giây: ");
            number = Convert.ToInt32(Console.ReadLine());
        } while (number <= 0);

        int seconds = number, minutes = 0, hours = 0;
        string seconds0, minutes0, hours0;

        if(number >= 60)
        {
            seconds = number % 60;
            minutes = number / 60;
            if (minutes >= 60)
            {
                hours = minutes/ 60;
                minutes = minutes % 60;
            }
        }
        
        if(seconds < 10)
        {
            seconds0 = "0" + seconds.ToString();
        }
        else
        {
            seconds0 = seconds.ToString();
        }

        if (minutes < 10)
        {
            minutes0 = "0" + minutes.ToString();
        }
        else
        {
            minutes0 = minutes.ToString();
        }

        if (hours < 10)
        {
            hours0 = "0" + hours.ToString();
        }
        else
        {
            hours0 = hours.ToString();
        }

        Console.WriteLine("{0}:{1}:{2}", hours0, minutes0, seconds0);
    }
}
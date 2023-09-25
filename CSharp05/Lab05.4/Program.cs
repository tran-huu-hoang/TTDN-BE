using Lab05._4;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Book b = new Book("Programming with Csharp", 4);
        //nhập thông tin các chương
        b[0] = new Chapter("Chapter 1", "Intoduction to Csharp");
        b[1] = new Chapter("Chapter 2", "DataType and Variables in Csharp");
        b[2] = new Chapter("Chapter 3" ,"Input and Output in Console Application");
        b[3] = new Chapter("Chapter 4", "Statements Conditions and Loops");
        //in thông tin sách
        Console.WriteLine("List of book");
        Console.WriteLine(b.Name);
        // danh sách chương
        for (int i = 0; i < 4; i++)
{
            Console.WriteLine(b[i]);
        }
        //thông tin chương 3
        Console.WriteLine("Detail of Chapter 3");
        Console.WriteLine(b["Chapter 3"]);
        Console.Read();
    }
}
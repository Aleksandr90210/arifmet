using System;
using System.Diagnostics;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите число");
        try
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " - вот какое число Вы ввели.");
        }
        catch
        {
            Console.WriteLine("Ты еблан ввел не число");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Text
{
    public static void Center(string text, bool light)
    {
        int center = (Console.WindowWidth - text.Length) / 2;
        for (int i = 0; i < center; i++)
        {
            Console.Write(" ");
        }
        if (light == true)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        if (light == false)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine(text);
    }
    public static void Typewrite(string text, int speed = 40)
    {
        foreach (char twch in text)
        {
            Console.Write(twch);
            System.Threading.Thread.Sleep(speed);
        }
        Console.WriteLine("");
    }
}

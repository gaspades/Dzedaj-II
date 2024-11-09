using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Background
{
    public static void Pattern(string shape, bool pulse)
    {
        if (pulse == true)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
        }
        if (pulse == false)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        for (int i = 0; i < Console.WindowHeight; i++)
        {
            for (int j = 0; j < Console.WindowWidth; j++)
            {
                if (shape == "square")
                {
                    Console.Write("╬");
                }
            }
            Console.WriteLine();
        }
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
    }
}
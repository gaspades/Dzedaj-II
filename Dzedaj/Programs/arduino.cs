using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Arduino
{
    public static void Start()
    {
        Arduino.Prompt();
    }
    public static void Prompt()
    {
        Text.Center("ARDUINO", false);
        Console.WriteLine();
        Text.Typewrite("<S> SAVE", 10);
        Text.Typewrite("<F5> NEXT LINE", 10);
        Text.Typewrite("<E> EXIT", 10);
        Arduino.Type(0);
    }
    public static void Type(int line)
    {
        line++;
        string note = null;
        Console.Write(line);
        Console.Write("] ");
        string text = Console.ReadLine();
        ConsoleKeyInfo control = Console.ReadKey();
        if (control.Key == ConsoleKey.E)
        {
            Console.Clear();
            Console.Beep();
            Terminal.Prompt();
        }
        if (control.Key == ConsoleKey.F5)
        {
            note = note + text + Environment.NewLine;
            Arduino.Type(line);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

public class Bookwrite
{
    public static void Start()
    {
        Bookwrite.Prompt();
    }
    public static void Prompt()
    {
        Text.Center("BOOKWRITE", false);
        Console.WriteLine();
        Text.Typewrite("<S> SAVE", 10);
        Text.Typewrite("<F5> NEXT LINE", 10);
        Text.Typewrite("<E> EXIT", 10);
        Bookwrite.Type();
    }
    public static void Type()
    {
        string note = null;
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
            Bookwrite.Type();
        }
        if (control.Key == ConsoleKey.F8)
        {
            control = Console.ReadKey();
            if (control.Key == ConsoleKey.LeftArrow)
            {
                control = Console.ReadKey();
                if (control.Key == ConsoleKey.LeftArrow)
                {
                    control = Console.ReadKey();
                    if (control.Key == ConsoleKey.Oem4)
                    {
                        Console.Clear();
                        Console.Beep();
                        Console.Beep(1250, 900);
                        Secret_Feature.ThemeTestRun();
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Writer
{
    public static void Start()
    {
        Writer.Prompt();
    }
    public static void Prompt()
    {
        Text.Center("WRITER", false);
        Console.WriteLine();
        Text.Typewrite("<ALT> CONTROL", 10);
        Text.Typewrite("<S> SAVE", 10);
        Text.Typewrite("<SHIFT+S> SAVE AS", 10);
        Text.Typewrite("<SHIFT+C> CLOSE DOCUMENT", 10);
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
    }
}
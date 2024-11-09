using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Secret_Feature
{
    public static void ThemeTestRun()
    {
        Text.Center("THEME TEST", false);
        Console.WriteLine();
        Text.Typewrite("YOU NEED TO INSERT WHAT TYPE OF THEME AND FM SIGNAL OF THEME.");
        Console.WriteLine();
        Console.Write("//THEME-TEST//TYPE%]");
        string type = Console.ReadLine();
        Console.Write("FM.NO //]");
        int fm = int.Parse(Console.ReadLine());
        SF_Interact.Theme_Test(type, fm);
    }
}

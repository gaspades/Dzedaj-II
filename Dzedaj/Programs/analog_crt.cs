using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AnalogCRT
{
    public static void Start()
    {
        AnalogCRT.Prompt();
    }
    public static void Prompt()
    {
        Text.Center("ANALOG CRT", false);
        Console.WriteLine();
        Text.Typewrite("<P> PLAY ANIMATION", 10);
        Text.Typewrite("<C> CREATE ANIMATION", 10);
        Text.Typewrite("<S> SETTINGS", 10);
        Text.Typewrite("<E> EXIT", 10);
        ConsoleKeyInfo vid_key = Console.ReadKey();
        if (vid_key.Key == ConsoleKey.P)
        {
            Console.Clear();
            string[] video = { "Landscape" };
            Text.Center("ANALOG CRT", false);
            Console.WriteLine();
            for (int j = 0; j < video.Length; j++)
            {
                Console.Write("*");
                Console.Write(video[j].ToUpper());
                for (int t = 0; t < (30 - video[j].Length); t++)
                {
                    Console.Write(" ");
                }
                Console.Write("ANALOG/DIGITAL VIDEO");
                for (int t = 0; t < 8; t++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("UNKNOWN DATE/TIME");
                Thread.Sleep(25);
            }
            Console.WriteLine();
            Console.Write("ACRT-/]");
            string play_vid = Console.ReadLine();
            Console.Clear();
            Animation.Play(play_vid);
            AnalogCRT.Prompt();
        }
        if (vid_key.Key == ConsoleKey.C)
        {
            Console.Clear();
            Text.Center("ANALOG CRT - CREATE ANIMATION", false);
            Console.WriteLine();
            Console.Write("Anim-WIDTH = ");
            int a_width = int.Parse(Console.ReadLine());
            Console.Write("Anim-HIGHT = ");
            int a_hight = int.Parse(Console.ReadLine());
            Console.Write("Anim-FPS = ");
            int a_frames = int.Parse(Console.ReadLine());
            int[,,] anim_matrix = new int[a_frames, a_hight, a_width];
            Console.WriteLine();
            Console.Write(" ");
            for (int k = 0; k < a_width; k++)
            {
                Console.Write(k);
            }
            Console.WriteLine();
            for (int j = 0; j < a_width; j++)
            {
                Console.Write(j);
                for (int k = 0; k < a_hight; k++)
                {
                    ConsoleKeyInfo bw_code = Console.ReadKey();
                    Graphic.DeathS("DZEDAJ ][ IS DEATH FOR WORKING ON UNSAFE , DISFUNCTIONAL AND UNWORKABLE FUNCTION ON ONE PROGRAM. ANALOG CRT CANNOT MAKE ANIMATION BECAUSE OF BAD GRAPHIC FOR TABLE AND SHEETS AND OTHER DISFUNCTIONS. SORRY FOR THAT.", 100002000);
                    //if (bw_code.Key == ConsoleKey.D0)
                    //{
                    //    Console.Write(" ");
                    //}
                    //if (bw_code.Key == ConsoleKey.D1)
                    //{
                    //    Console.Write("░");
                    //}
                    //if (bw_code.Key == ConsoleKey.D2)
                    //{
                    //    Console.Write("▒");
                    //}
                    //if (bw_code.Key == ConsoleKey.D3)
                    //{
                    //    Console.Write("▓");
                    //}
                    //if (bw_code.Key == ConsoleKey.D4)
                    //{
                    //    Console.Write("█");
                    //}
                }
                Console.WriteLine();
            }
            Terminal.Prompt();

        }
        if (vid_key.Key == ConsoleKey.E)
        {
            Console.Clear();
            Console.Beep();
        }
    }
}

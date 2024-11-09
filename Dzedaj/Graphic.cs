using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Graphic
{
    public static void Image(int[,] image)
    {
        for (int i = 0; i < image.GetLength(0); i++)
        {
            for (int j = 0; j < image.GetLength(1); j++)
            {
                if (image[i, j] == 0)
                {
                    Console.Write(" ");
                }
                if (image[i, j] == 1)
                {
                    Console.Write("░");
                }
                if (image[i, j] == 2)
                {
                    Console.Write("▒");
                }
                if (image[i, j] == 3)
                {
                    Console.Write("▓");
                }
                if (image[i, j] == 4)
                {
                    Console.Write("█");
                }
            }
            Console.WriteLine();
        }
    }
    public static void Video(int[,,] video, int fps)
    {
        for (int i = 0; i < video.GetLength(0); i++)
        {
            Console.Write("╔");
            for (int video_w = 1; video_w < video.GetLength(1); video_w++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╗");
            for (int j = 0; j < video.GetLength(1); j++)
            {
                Console.Write("║");
                for (int k = 0; k < video.GetLength(2); k++)
                {
                    if (video[i, j, k] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (video[i, j, k] == 1)
                    {
                        Console.Write("░");
                    }
                    if (video[i, j, k] == 2)
                    {
                        Console.Write("▒");
                    }
                    if (video[i, j, k] == 3)
                    {
                        Console.Write("▓");
                    }
                    if (video[i, j, k] == 4)
                    {
                        Console.Write("█");
                    }
                }
                Console.Write("║");
                Console.WriteLine();
            }
            Console.Write("╚");
            for (int video_w = 1; video_w < video.GetLength(1); video_w++)
            {
                Console.Write("═");
            }
            Console.WriteLine("╝");
            Thread.Sleep(fps);
            Console.Clear();
        }
    }
    public static void Crash()
    {
        int[,] noise = new int[Console.WindowHeight, Console.WindowWidth];
        Random random = new Random();
        for (; ; )
        {
            for (int i = 0; i < noise.GetLength(0); i++)
            {
                for (int j = 0; j < noise.GetLength(1); j++)
                {
                    int rnd_pix = random.Next(0, 5);
                    noise[i, j] = rnd_pix;
                    if (noise[i, j] == 0)
                    {
                        Console.Write(" ");
                    }
                    if (noise[i, j] == 1)
                    {
                        Console.Write("░");
                    }
                    if (noise[i, j] == 2)
                    {
                        Console.Write("▒");
                    }
                    if (noise[i, j] == 3)
                    {
                        Console.Write("▓");
                    }
                    if (noise[i, j] == 4)
                    {
                        Console.Write("█");
                    }
                }
                Console.WriteLine();
            }
            Console.Clear();
        }
    }
    public static void DeathS(string reason, int error_code)
    {
        Console.Clear();
        Text.Center("ANNIHILATED DZEDAJ", true);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.WriteLine(reason);
        Console.WriteLine();
        Console.Write("Console error code: ");
        Console.WriteLine(error_code);
        for (; ; )
        {
            Console.Beep(1250, 2000);
        }
    }
    public static void Illegal(object sender, UnhandledExceptionEventArgs UEEA)
    {
        Exception bug = (Exception) UEEA.ExceptionObject;
        Console.Clear();
        Text.Center("ILLEGAL BUG", true);
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.White;
        //Console.WriteLine();
        //Console.WriteLine(reason);
        Console.WriteLine();
        Console.WriteLine(bug.Message.ToUpper());
        Console.WriteLine();
        Console.WriteLine(bug.StackTrace.ToUpper());
        Console.WriteLine();
        Console.WriteLine("PLEASE RESET YOUR TERMINAL TO GET BACK");
        Console.WriteLine();
        //Console.Write("Console error code: ");
        //Console.WriteLine(error_code);
        for (; ; )
        {
            Console.Beep(1250, 2000);
        }
    }
}
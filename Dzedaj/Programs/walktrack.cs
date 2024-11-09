using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Media;

public class WalkTrack
{
    public static void Start()
    {
        Text.Center("WALKTRACK 2", false);
        Console.WriteLine();
        Text.Typewrite("WALKTRACK IS A PROGRAM FOR PLAYING AND LISTENING AUDIO AND MUSIC. WALKTRACK SUPPORT JUST WAVE FILE 'WAV'.");
        Console.WriteLine();
        Text.Typewrite("<P> PLAY AUDIO/MUSIC", 10);
        Text.Typewrite("<S> SETTINGS", 10);
        Text.Typewrite("<E> EXIT", 10);
        Console.WriteLine();
        WalkTrack.PromptWT();
    }
    private static void PromptWT()
    {
        ConsoleKeyInfo wt_key = Console.ReadKey();
        if (wt_key.Key == ConsoleKey.P)
        {
            Console.Clear();
            string[] audio = { "the clash - rock the casbah", "django django - firewater" };
            Text.Center("WALKTRACK 2", false);
            Console.WriteLine();
            for (int j = 0; j < audio.Length; j++)
            {
                Console.Write("*");
                Console.Write(audio[j].ToUpper());
                for (int t = 0; t < (30 - audio[j].Length); t++)
                {
                    Console.Write(" ");
                }
                Console.Write("AUDIO");
                for (int t = 0; t < 8; t++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("UNKNOWN DATE/TIME");
                Thread.Sleep(25);
            }
            Console.WriteLine();
            Console.Write("WT-/]");
            string play_a = Console.ReadLine();
            Console.Clear();
            Text.Center("WALKTRACK", false);
            Console.WriteLine();
            Album.PrintART(play_a);
            Console.WriteLine();
            Console.WriteLine(play_a.ToUpper());
            Console.WriteLine();
            Console.WriteLine("<S> STOP AUDIO");
            string play_direction = play_a + ".wav";
            SoundPlayer audio_file = new SoundPlayer(play_direction);
            audio_file.Load();
            audio_file.Play();
            ConsoleKeyInfo mediaControl = Console.ReadKey();
            if (mediaControl.Key == ConsoleKey.S)
            {
                audio_file.Stop();
                Console.WriteLine();
                WalkTrack.PromptWT();
            }
        }
        if (wt_key.Key == ConsoleKey.E)
        {
            Console.Clear();
            Console.Beep();
            Terminal.Prompt();
        }
    }

    private static void PlayAudio(string play_af)
    {
        if (OperatingSystem.IsWindows())
        {
            SoundPlayer audio_file = new SoundPlayer(play_af);
            audio_file.Load();
            audio_file.Play();
        }
    }
}

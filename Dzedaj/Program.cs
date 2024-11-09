using System;
using System.ComponentModel;
using System.IO;
using System.Media;

public class Terminal
{
    public static DirectoryInfo LD = new DirectoryInfo(@"C:\Users\neven\source\repos\Dzedaj\Dzedaj");
    public static void Main()
    {
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(Graphic.Illegal);
        Console.Beep();
        Console.Title = "Džedaj II";
        Background.Pattern("square", false);
        Thread.Sleep(1000);
        Console.Clear();
        Text.Center("DZEDAJ ][", false);
        ConsoleKeyInfo reset;
        reset = Console.ReadKey();
        if (reset.Key == ConsoleKey.Backspace)
        {
            Console.Beep();
            Console.Clear();
            Terminal.Prompt();
        }
    }
    public static void Prompt()
    {
        FileInfo[] LD_files = LD.GetFiles();
        string[] commands = { "list", "newcata", "run", "calc", "tell", "charloop", "osinfo", "coreinfo", "countloop", "crash", "copyfile", "move", "copydata", "codeyork", "clear", "mountdisco", "listcata" };
        string[] programs = { "assembler", "arduino", "bookwrite", "writer", "breakintosh", "walktrack", "analog_crt" };
        string command;
        Console.Write("]");
        command = Console.ReadLine();
        Console.WriteLine();
        for (int i = 0; i < commands.Length; i++)
        {
            if (command == commands[i])
            {
                if (command == "list")
                {
                    for (int j = 0; j < commands.Length; j++)
                    {
                        Console.Write("*");
                        Console.Write(commands[j].ToUpper());
                        for (int t = 0; t < (12 - commands[j].Length); t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("COMMAND");
                        for (int t = 0; t < 6; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("UNKNOWN DATE/TIME");
                        Thread.Sleep(25);
                    }
                    for (int pr = 0; pr < programs.Length; pr++)
                    {
                        Console.Write("*");
                        Console.Write(programs[pr].ToUpper());
                        for (int t = 0; t < (12 - programs[pr].Length); t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("PROGRAM");
                        for (int t = 0; t < 6; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine("UNKNOWN DATE/TIME");
                        Thread.Sleep(25);
                    }
                }
                if (command == "newcata")
                {
                    Console.Write("/~~]");
                    string new_catalog = Console.ReadLine();
                    if (new_catalog == "LD")
                    {
                        LD = new DirectoryInfo(@"C:\Users\neven\source\repos\Dzedaj\Dzedaj");
                    }
                    if (new_catalog == "FS")
                    {
                        LD = new DirectoryInfo(@"C:\Users\neven\source\repos\Dzedaj\Dzedaj\bin\Debug\net6.0");
                    }
                    else
                    {
                        LD = new DirectoryInfo(@new_catalog);
                    }
                }
                if (command == "run")
                {
                    Console.Write("-/]");
                    string program = Console.ReadLine();
                    for (int pr = 0; pr < programs.Length; pr++)
                    {
                        if (program == programs[pr])
                        {
                            Run(program);
                        }
                    }
                }
                if (command == "calc")
                {
                    Console.Write("C/]");
                    string cl = Console.ReadLine();
                    string[] math = cl.Split(' ');
                    RD.Operate(math[0], math[1], math[2]);
                }
                if (command == "tell")
                {
                    Console.Write(">T]");
                    string tell = Console.ReadLine();
                    Console.WriteLine(tell);
                }
                if (command == "charloop")
                {
                    for (; ; )
                    {
                        Console.WriteLine("ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890[]{}?!@#$%^&*(),.<>;:'~/");
                        Thread.Sleep(50);
                    }
                }
                if (command == "osinfo")
                {
                    Text.Typewrite("OS: DZEDAJ");
                    Text.Typewrite("VERSION: 2");
                    Text.Typewrite("DEVELOPER: GALACTIC SPACE DESIGNER");
                    Text.Typewrite("COMPILER: C#");
                    Text.Typewrite("APP: CONSOLE");
                }
                if (command == "coreinfo")
                {
                    Text.Typewrite("RADIODRAGON OPERATING CORE 1");
                    Text.Typewrite("CORE FOR CALCULATING OPERATIONS");
                    Text.Typewrite("ADDITION, SUBTRACTION, MULTIPLICATION, DIVISION, POW, SQRT, ABS");
                }
                if (command == "crash")
                {
                    Graphic.Crash();
                }
                if (command == "codeyork")
                {
                    //Text.Typewrite("This command have fatal mistake and it cannot work normally.", 15);
                    //Terminal.Prompt();
                    int trocket = 0;
                    Console.Write("<CY]");
                    string task_line = Console.ReadLine();
                    Graphic.Crash();
                    //string[] task_code = task_line.Split(' ');
                    //trocket++;
                    //string[,] task_matrix = new string[trocket,task_code.Length];
                    //for (i = 0; i < task_code.Length; i++)
                    //{
                    //    task_matrix[trocket, i] = task_code[i];
                    //}
                }
                if (command == "clear")
                {
                    Console.Clear();
                    Console.Beep(1250, 900);
                }
                if (command == "countloop")
                {
                    int count = 0;
                    for (; ; )
                    {
                        count++;
                        Text.Center(count.ToString(), false);
                        Thread.Sleep(50);
                    }
                }
                if (command == "mountdisco")
                {
                    Console.Write("<DISK--]");
                    string diskette = Console.ReadLine();
                    Console.Beep(1250, 900);
                    Console.Beep(1250, 900);
                    Console.Beep(1250, 2000);
                    if (diskette == "D1")
                    {
                        string D1path = @".\Diskette\D1\start.zip";
                        FileInfo D1path_s = new FileInfo(D1path);
                        string D1extract = @".\Diskette\D1_E";
                        FileInfo D1extract_s = new FileInfo(D1extract);
                        if (!D1path_s.Exists)
                        {
                            Console.Beep(1250, 900);
                            Console.Beep(1250, 900);
                            Text.Typewrite("DISKETTE 1 IS EMPTY");
                            Text.Typewrite("THERE IS NO ANY ZIP/ARCHIVE FILE OR DISKETTE");
                        }
                        if (D1path_s.Exists)
                        {
                            Console.Beep(1250, 2000);
                            System.IO.Compression.ZipFile.ExtractToDirectory(D1path, D1extract);
                            Text.Typewrite("DISKETTE 1 WAS FOUND");
                            Text.Typewrite("OPENING AND READING DISKETTE 1");
                            Text.Typewrite("NOW YOU CAN OPERATE ON DISKETTE 1");
                            DiskPrompt(D1extract);
                        }
                    }
                    if (diskette == "D2")
                    {
                        string D2path = @".\Diskette\D2\start.zip";
                        string D2extract = @".\Diskette\D1_E";
                        if (!File.Exists(D2path))
                        {
                            Console.Beep(1250, 900);
                            Console.Beep(1250, 900);
                            Text.Typewrite("DISKETTE 2 IS EMPTY");
                            Text.Typewrite("THERE IS NO ANY ZIP/ARCHIVE FILE OR DISKETTE");
                        }
                        if (File.Exists(D2path))
                        {

                        }
                    }
                }
                if (command == "listcata")
                {
                    for (int j = 0; j < LD_files.Length; j++)
                    {
                        Console.Write("*");
                        Console.Write(Path.GetFileNameWithoutExtension(LD_files[j].Name).ToUpper());
                        for (int t = 0; t < (50 - LD_files[j].Name.Length); t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(LD_files[j].Extension.Replace(".", " ").ToUpper());
                        for (int t = 0; t < 6; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine(LD_files[j].CreationTime.Date);
                        Thread.Sleep(25);
                    }
                    DirectoryInfo[] LD_directions = LD.GetDirectories();
                    for (int j = 0; j < LD_directions.Length; j++)
                    {
                        Console.Write("*");
                        Console.Write(Path.GetFileName(LD_directions[j].Name).ToUpper());
                        for (int t = 0; t < (50 - LD_directions[j].Name.Length); t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("folder".ToUpper());
                        for (int t = 0; t < 10; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine(LD_directions[j].CreationTime.Date);
                        Thread.Sleep(25);
                    }
                }
                if (command == "move")
                {
                    Console.Write("//~]");
                    string move_file = Console.ReadLine();
                    Console.Write("/~/]");
                    string move_directory = Console.ReadLine();
                    File.Move(@move_file, @move_directory);
                    Console.Write("FILE ");
                    Console.Write(move_file);
                    Console.Write(" IS SUCCESFULY MOVED INTO ");
                    Console.Write(move_directory);
                    Console.WriteLine(" DIRECTORY");
                }
                if (command == "copyfile")
                {
                    Console.Write("/C~]");
                    string copy_file = Console.ReadLine();
                    Console.Write("/~C]");
                    string copying_directory = Console.ReadLine();
                    File.Copy(@copy_file, @copying_directory);
                    Console.Write("FILE ");
                    Console.Write(copy_file);
                    Console.Write(" IS SUCCESFULY COPIED INTO ");
                    Console.Write(copying_directory);
                    Console.WriteLine(" DIRECTORY");
                }
                Console.WriteLine();
                Terminal.Prompt();
            }
        }
        if (command == "menstruate")
        {
            Console.WriteLine("Damn it! You literally killed your terminal.");
            Thread.Sleep(3000);
            Environment.Exit(-99999999);
        }
        if (command == "autism")
        {
            for(; ; )
            {
                Random rand = new Random();
                Console.Write("MEDGOvrska cannot understand this ANsvuer?!?11/");
                Thread.Sleep(10);
            }
        }
        if (command == "electronica")
        {
            Console.Clear();
            Graphic.Image(IMGmatrix.doll);
        }
        if (command == "Hail Satan" || command == "hail satan" || command == "Hail Satan!!!" || command == "hail Satan")
        {
            Console.WriteLine("SAY THAT AGAIN YOU COMPLEX IDIOT AND YOU WILL BE BANNED FOR USING DZEDAJ FOR SHITS!!!");
        }
        if (command is int)
        {
            if (int.Parse(command) < 0)
            {
                Terminal.Prompt();
            }
        }
        else
        {

            Console.WriteLine("SYNTAX ERROR!");
            Terminal.Prompt();
        }
    }

    public static void DiskPrompt(string D1extract)
    {
        string Dcommand;
        string[] Dcommands = { "list", "newcata", "run", "diskinfo", "copyfile", "move", "copydata", "disk_exit", "savedisk" };
        Console.Write("<DISK1~]");
        Dcommand = Console.ReadLine();
        for (int dc = 0; dc < Dcommands.Length; dc++)
        {
            if (Dcommand == Dcommands[dc])
            {
                DirectoryInfo D1dir = new DirectoryInfo(D1extract);
                FileInfo[] fileInfos = D1dir.GetFiles();
                if (Dcommand == "list")
                {
                    for (int j = 0; j < fileInfos.Length; j++)
                    {
                        Console.Write("*");
                        Console.Write(Path.GetFileNameWithoutExtension(fileInfos[j].Name).ToUpper());
                        for (int t = 0; t < (12 - fileInfos[j].Length); t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(fileInfos[j].Extension.Replace(".", " ").ToUpper());
                        for (int t = 0; t < 6; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.WriteLine(fileInfos[j].CreationTime.Date);
                        Thread.Sleep(25);
                    }
                    Console.WriteLine();
                    Terminal.DiskPrompt(D1extract);
                }
                if (Dcommand == "disk_exit")
                {
                    //Graphic.DeathS("DZEDAJ ][ IS DEAD BECAUSE OF TECHNICAL ISSUES. DZEDAJ CANNOT EXIT SAFELY FROM DISKETTES BECAUSE BAD ALGORYTHM FOR OPERATING ON DISKETTE. ALL FILES WILL STAY INSIDE THE 'E' DIRECTORY. JUST RESTART TERMINAL AND TERMINAL WILL BE RIGHT BACK.", 300301);
                    Text.Typewrite("DISKETTE 1 IS EJECTED.");
                    Text.Typewrite("SOME FILES WHO IS NOT CORRECTLY SAVED IN DISKETTE 1 IS LOSED.");
                    Text.Typewrite("YOU CAN EJECT ZIP/ARCHIVE FILE FROM D1 FOLDER");
                    for (int j = 0; j < fileInfos.Length; j++)
                    {
                        fileInfos[j].Delete();
                    }
                    Terminal.Prompt();
                }
                if (Dcommand == "run")
                {
                    Console.Clear();
                    Console.Beep();
                    Console.Beep(1250, 900);
                    Console.WriteLine();
                    Terminal.DiskPrompt(D1extract);
                }
            }
        }
    }

    public static void Run(string program)
    {
        Console.Clear();
        Console.Beep();
        Console.Beep(1250, 900);
        if (program == "walktrack")
        {
            WalkTrack.Start();
        }
        if (program == "bookwrite")
        {
            Bookwrite.Start();
        }
        if (program == "writer")
        {
            Writer.Start();
        }
        if (program == "breakintosh")
        {
            Writer.Start();
        }
        if (program == "analog_crt")
        {
            AnalogCRT.Start();
        }
        if (program == "arduino")
        {
            Arduino.Start();
        }
        if (program == "assembler")
        {
            Assembler.Start();
        }
    }
}
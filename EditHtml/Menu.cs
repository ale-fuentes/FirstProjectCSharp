using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;

            DrawScreen();
            WriteOptions();

            short option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            char indent = '-';

            Console.Write("+");
            Console.Write(string.Empty.PadLeft(30, indent));
            Console.Write("+");

            Console.Write("\n");

            for (int x = 0; x < 11; x++)
            {
                Console.Write("|");
                Console.Write(string.Empty.PadLeft(30));
                Console.WriteLine("|");
            }

            Console.Write("+");
            Console.Write(string.Empty.PadLeft(30, indent));
            Console.Write("+");

        }

        public static void WriteOptions()
        {

            Console.SetCursorPosition(0, 0); Console.Write("0:0");
            Console.SetCursorPosition(1, 1); Console.Write("1:1");

            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HMTL");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("-----------");

            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Select one option:");

            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1- New file");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2- Open file");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0- Exit");

            Console.SetCursorPosition(3, 10);
            Console.Write("Option? : ");

        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1: Editor.Show(); break;
                case 2: break;
                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;
            }
        }

    }
}
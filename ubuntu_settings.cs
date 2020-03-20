using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows;

namespace settings_for_platform
{
   /// <summary>
   /// настройки ubuntu
   /// </summary>
    class ubuntu_settings:settings
    {
        public string type()
        {
            return "Ubuntu";
        }
        public string getSet1()
        {

            return "screen size for " + type() + " " + Console.WindowWidth + "x" + Console.WindowHeight;
        }
        public string getSet2()
        {
            return "buffer size for " + type() + " " + Console.BufferWidth + "x" + Console.BufferHeight;
        }
        public string getSet3()
        {
            Console.Title = type();
            return "session title was setted in " + Console.Title;
        }
        public string getSet4()
        {
            
            
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            return "color settings were setted ";
        }
        public string getSet5()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.SetCursorPosition(Console.WindowWidth - 4, Console.WindowHeight-1);
            return "edge";
        }
        public string getSet6()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(10, 5);
            return "Welcome message test";
        }
        public string getSet7()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            return "cursor was disabled for " + type();
        }
        public string getSet8()
        {
            
            return "encoding: " + Console.OutputEncoding.ToString();
        }
        public string getSet9()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            return "contrast test ";
        }
        public string getSet10()
        {
            return "... WELCOME to " + type();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            string type;
            Console.WriteLine("введите тип ос");
            type = Console.ReadLine();
            if (type == "windows")
                new client().windowsSet();
            else if (type == "macos")
                new client().macOSSet();
            else if (type == "ubuntu")
                new client().ubuntuSet();
            else
                Console.WriteLine("ops");

            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace settings_for_platform
{
    /// <summary>
    /// клиент
    /// </summary>
    class client
    {
        /// <summary>
        /// настройка windows
        /// </summary>
        public void windowsSet()
        {
            cl(new windows_switcher());
        }
        /// <summary>
        /// настройка macos
        /// </summary>
        public void macOSSet()
        {
            cl(new macos_switcher());
        }
        /// <summary>
        /// настройка ubuntu
        /// </summary>
        public void ubuntuSet()
        {
            cl(new ubuntu_switcher());
        }


        /// <summary>
        /// выводим настройки в зависимости от типа системы
        /// </summary>
        /// <param name="sw"></param>
        public void cl(switcher sw)
        {
            Console.WriteLine(sw.getSettings().getSet4());
            Console.WriteLine(sw.getSettings().type());
            
            Console.WriteLine(sw.getSettings().getSet1());
            Console.WriteLine(sw.getSettings().getSet2());
            Console.WriteLine(sw.getSettings().getSet3());
            Console.Write(sw.getSettings().getSet5());
            Console.WriteLine(sw.getSettings().getSet6());
            Console.WriteLine(sw.getSettings().getSet7());
            Console.WriteLine(sw.getSettings().getSet8());
            Console.WriteLine(sw.getSettings().getSet9());

        }

    }
}

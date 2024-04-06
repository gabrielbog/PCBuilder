using PCBuilder.Classes.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = Menu.GetInstance();
            menu.ShowGreeting();
            menu.StartLoop();
        }
    }
}

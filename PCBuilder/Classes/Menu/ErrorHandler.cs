using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Menu
{
    public class ErrorHandler
    {
        public static void ShowError(int code)
        {
            switch(code)
            {
                case 0:
                    Console.WriteLine("The selected option is invalid. Try again.\n");
                    break;
            }
        }
    }
}

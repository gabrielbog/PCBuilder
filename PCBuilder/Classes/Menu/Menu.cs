using PCBuilder.Classes.Context;
using PCBuilder.Classes.Data.Repositories;
using PCBuilder.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Menu
{
    public class Menu
    {
        private static Menu inst = null;
        private OptionRepository repository;

        private Menu()
        {
            repository = OptionRepository.GetInstance();
        }

        public static Menu GetInstance()
        {
            if (inst == null)
                inst = new Menu();
            return inst;
        }

        //functions
        public void ShowGreeting()
        {
            Console.WriteLine("Welcome to our PC Store!\n");
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("If you wish to view our catalogue, select an option from the list below:");
            ShowMenuOptions();
        }

        public void ShowMenuOptions()
        {
            int ct = 1;
            List<String> names = repository.GetAllOptionNames();
            foreach(String name in names)
            {
                Console.WriteLine(ct + ": " + name);
                ct++;
            }
            Console.WriteLine(0 + ": " + "Close the application");
        }

        public void ShowSelectedOption(int val)
        {
            Option option = repository.GetOption(val);
            if(option != null)
            {
                PC pc = option.GetBuildOption();
                Console.WriteLine(pc.ShowDetails());
                Console.WriteLine("Total price: " + pc.CalculatePrice() + "\n");
            }
            else
            {
                ErrorHandler.ShowError(0);
            }
        }

        public string AwaitOption()
        {
            Console.Write("Write your option: ");
            string val = Console.ReadLine();
            return val.Trim();
        }

        public int VerifyOption(string key)
        {
            int res = -1;
            bool canConvert = int.TryParse(key, out res);
            if (canConvert)
                return res;
            else
                return -1;
        }

        public void StartLoop()
        {
            bool appClosed = false;

            while(!appClosed)
            {
                ShowMainMenu();
                string valStr = AwaitOption();
                int val = VerifyOption(valStr);
                if(val != -1)
                {
                    if(val == 0)
                    {
                        appClosed = true;
                        break;
                    }
                    else
                    {
                        ShowSelectedOption(val);
                    }
                }
                else
                {
                    ErrorHandler.ShowError(0);
                }
            }
        }
    }
}

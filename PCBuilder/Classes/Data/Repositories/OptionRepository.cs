using PCBuilder.Classes.Context;
using PCBuilder.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Data.Repositories
{
    public class OptionRepository
    {
        private static OptionRepository inst = null;
        private DataContext context;

        private OptionRepository()
        {
            context = DataContext.GetInstance();
        }

        public static OptionRepository GetInstance()
        {
            if (inst == null)
                inst = new OptionRepository();
            return inst;
        }

        public List<String> GetAllOptionNames()
        {
            List<String> nameList = new List<String>();
            foreach(Option option in context.options)
            {
                nameList.Add(option.name);
            }
            return nameList;
        }

        public Option GetOption(int val)
        {
            int realVal = val - 1;
            if (realVal < 0 || realVal >= context.options.Count)
                return null;
            return context.options[realVal];
        }
    }
}

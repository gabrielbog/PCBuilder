using PCBuilder.Classes.Data.Models;
using PCBuilder.Classes.Menu;
using PCBuilder.Classes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Context
{
    public class DataContext
    {
        private static DataContext inst = null;
        public List<Option> options { get; set; }

        private DataContext()
        {
            options = new List<Option>();
            LoadData();
        }

        public static DataContext GetInstance()
        {
            if (inst == null)
                inst = new DataContext();
            return inst;
        }

        private void LoadData()
        {
            //here should be a different method to load the data in general
            options.Add(new LowRangeOption());
            options.Add(new MidRangeOption());
            options.Add(new HighRangeOption());
        }
    }
}

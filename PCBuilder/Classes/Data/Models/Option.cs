using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Models
{
    public abstract class Option
    {
        public string name;
        
        public Option()
        {

        }

        public abstract PC GetBuildOption();
    }
}

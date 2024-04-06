using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class RAM : Product
    {
        //variables
        public string memoryType { get; private set; }
        public int memorySize { get; private set; }
        public int frequency { get; private set; }
        public int nrSticks { get; private set; }

        //constructor
        public RAM(string name, double price, string memoryType, int memorySize, int frequency, int nrSticks) : base(name, price)
        {
            this.memoryType = memoryType;
            this.memorySize = memorySize;
            this.frequency = frequency;
            this.nrSticks = nrSticks;
        }

        //functions
        public override string ShowDetails()
        {
            return "RAM: " + name + ", memory type: " + memoryType + ", memory size: " + memorySize + " GB, frequency: " + frequency + "no. of sticks: " + nrSticks;
        }
    }
}

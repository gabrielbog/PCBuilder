using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class HDD : Product
    {
        //variables
        public int capacity { get; private set; }
        public int rpm { get; private set; }
        public string format { get; private set; }

        //constructor
        public HDD(string name, double price, int capacity, int rpm, string format) : base(name, price)
        {
            this.capacity = capacity;
            this.rpm = rpm;
            this.format = format;
        }

        //functions
        public override string ShowDetails()
        {
            return "HDD: " + name + ", capacity: " + capacity + " GB, RPM: " + rpm + ", format: " + format;
        }
    }
}

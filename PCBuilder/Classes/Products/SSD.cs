using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class SSD : Product
    {
        //variables
        public int capacity { get; private set; }
        public int maxReadSpeed { get; private set; }
        public int maxWriteSpeed { get; private set; }
        public string format { get; private set; }

        //constructor
        public SSD(string name, double price, int capacity, int maxReadSpeed, int maxWriteSpeed, string format) : base(name, price)
        {
            this.capacity = capacity;
            this.maxReadSpeed = maxReadSpeed;
            this.maxWriteSpeed = maxWriteSpeed;
            this.format = format;
        }

        //functions
        public override string ShowDetails()
        {
            return "SSD: " + name + ", capacity: " + capacity + " GB, max. reading speed: " + maxReadSpeed + " MB/s, max. writing speed: " + maxWriteSpeed + " MB/s";
        }
    }
}

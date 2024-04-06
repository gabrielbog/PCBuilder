using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class CPU : Product
    {
        //variables
        public int cores { get; private set; }
        public double frequency { get; private set; }
        public int power { get; private set; }

        //constructor
        public CPU(string name, double price, int cores, double frequency, int power) : base(name, price)
        {
            this.cores = cores;
            this.frequency = frequency;
            this.power = power;
        }

        //functions
        public override string ShowDetails()
        {
            return "CPU: " + name + ", cores: " + cores + ", frequency: " + frequency + " GHz, power consumption: " + power + " W";
        }
    }
}

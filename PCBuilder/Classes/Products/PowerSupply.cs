using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class PowerSupply : Product
    {
        //variables
        public int power { get; private set; }
        public string certification { get; private set; }

        //constructor
        public PowerSupply(string name, double price, int power, string certification) : base(name, price)
        {
            this.power = power;
            this.certification = certification;
        }

        //functions
        public override string ShowDetails()
        {
            return "Power Supply: " + name + ", power: " + power + ", certification: " + certification;
        }
    }
}

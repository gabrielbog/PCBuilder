using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes
{
    public abstract class Product
    {
        //variables
        public string name { get; private set; }
        public double price { get; private set; }

        //constructor
        public Product(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        //functions
        public abstract string ShowDetails();
    }
}

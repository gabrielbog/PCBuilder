using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class Cooler : Product
    {
        //variables
        public string type { get; private set; }

        //constructor
        public Cooler(string name, double price, string type) : base(name, price)
        {
            this.type = type;
        }

        //functions
        public override string ShowDetails()
        {
            return "Cooler: " + name + ", type: " + type;
        }
    }
}

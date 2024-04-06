using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class Motherboard : Product
    {
        //variables
        public bool hasIntegratedAudio { get; private set; }

        //constructor
        public Motherboard(string name, double price, bool hasIntegratedAudio) : base(name, price)
        {
            this.hasIntegratedAudio = hasIntegratedAudio;
        }

        //functions
        public override string ShowDetails()
        {
            return "Motherboard: " + name + ", has integrated audio: " + hasIntegratedAudio;
        }
    }
}

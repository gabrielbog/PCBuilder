using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class GPU : Product
    {
        //variables
        public string memoryType { get; private set; }
        public int memorySize { get; private set; }
        public int fans { get; private set; }
        public int portsHdmi { get; private set; }
        public int portsDisplayPort { get; private set; }
        public int power { get; private set; }

        //constructor
        public GPU(string name, double price, string memoryType, int memorySize, int fans, int portsHdmi, int portsDisplayPort, int power) : base(name, price)
        {
            this.memoryType = memoryType;
            this.memorySize = memorySize;
            this.fans = fans;
            this.portsHdmi = portsHdmi;
            this.portsDisplayPort = portsDisplayPort;
            this.power = power;
        }

        //functions
        public override string ShowDetails()
        {
            return "GPU: " + name + ", memory type: " + memoryType + ", memory size: " + memorySize + " GB, nr. of fans: " + fans + ", nr. of HDMI ports: " + portsHdmi + ", nr. of DisplayPort ports: " + portsDisplayPort + ", power consumption: " + power + " W";
        }
    }
}

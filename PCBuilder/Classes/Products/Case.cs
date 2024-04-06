using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Products
{
    public class Case : Product
    {
        //variables
        public string format { get; private set; }
        public string lateralPanelType { get; private set; }
        public int fansFront { get; private set; }
        public int fansRear { get; private set; }

        //constructor
        public Case(string name, double price, string format, string lateralPanelType, int fansFront, int fansRear) : base(name, price)
        {
            this.format = format;
            this.lateralPanelType = lateralPanelType;
            this.fansFront = fansFront;
            this.fansRear = fansRear;
        }

        //functions
        public override string ShowDetails()
        {
            return "Case: " + name + ", format: " + format + ", lateral panel type: " + lateralPanelType + ", nr. of fans at the front: " + fansFront + ", nr. of fans at the rear: " + fansRear;
        }
    }
}

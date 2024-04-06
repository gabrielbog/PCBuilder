using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes
{
    public class PC
    {
        private Case caseCover;
        private Cooler cooler;
        private CPU cpu;
        private GPU gpu;
        private HDD hdd;
        private Motherboard motherboard;
        private PowerSupply powersupply;
        private RAM ram;
        private SSD ssd;

        public PC(Case caseCover, Cooler cooler, CPU cpu, GPU gpu, HDD hdd, Motherboard motherboard, PowerSupply powersupply, RAM ram, SSD ssd)
        {
            this.caseCover = caseCover;
            this.cooler = cooler;
            this.cpu = cpu;
            this.gpu = gpu;
            this.hdd = hdd;
            this.motherboard = motherboard;
            this.powersupply = powersupply;
            this.ram = ram;
            this.ssd = ssd;
        }
    
        public string ShowDetails()
        {
            return caseCover.ShowDetails() + "\n"
                 + motherboard.ShowDetails() + "\n"
                 + ram.ShowDetails() + "\n"
                 + cpu.ShowDetails() + "\n"
                 + cooler.ShowDetails() + "\n"
                 + gpu.ShowDetails() + "\n"
                 + powersupply.ShowDetails() + "\n"
                 + hdd.ShowDetails() + "\n"
                 + ssd.ShowDetails() + "\n";
        }

        public double CalculatePrice()
        {
            return caseCover.price + motherboard.price + ram.price + cpu.price + cooler.price + gpu.price + powersupply.price + hdd.price + ssd.price;
        }
    }
}

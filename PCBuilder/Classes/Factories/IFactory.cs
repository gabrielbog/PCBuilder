using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Factories
{
    public interface IFactory
    {
        public Case GetCase();
        public Cooler GetCooler();
        public CPU GetCPU();
        public GPU GetGPU();
        public HDD GetHDD();
        public Motherboard GetMotherboard();
        public PowerSupply GetPowerSupply();
        public RAM GetRAM();
        public SSD GetSSD();
    }
}

using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Factories
{
    public class AsusFactory : IFactory
    {
        public Case GetCase()
        {
            return new Case(
                name: "ASUS Case",
                price: 500,
                format: "mATX",
                lateralPanelType: "glass",
                fansFront: 2,
                fansRear: 0);
        }

        public Cooler GetCooler()
        {
            return new Cooler(
                name: "ASUS Cooler",
                price: 200,
                type: "air");
        }

        public CPU GetCPU()
        {
            return new CPU(
                name: "ASUS CPU",
                price: 1000,
                cores: 4,
                frequency: 3.6,
                power: 105);
        }

        public GPU GetGPU()
        {
            return new GPU(
                name: "ASUS GPU",
                price: 2000,
                memoryType: "GDDR6",
                memorySize: 8,
                fans: 2,
                portsHdmi: 2,
                portsDisplayPort: 2,
                power: 165);
        }

        public HDD GetHDD()
        {
            return new HDD(
                name: "ASUS HDD",
                price: 100,
                capacity: 1000,
                rpm: 7200,
                format: "3.5");
        }

        public Motherboard GetMotherboard()
        {
            return new Motherboard(
                name: "ASUS Motherboard",
                price: 400,
                hasIntegratedAudio: false);
        }

        public PowerSupply GetPowerSupply()
        {
            return new PowerSupply(
                name: "ASUS Power Supply",
                price: 400,
                power: 750,
                certification: "bronze");
        }

        public RAM GetRAM()
        {
            return new RAM(
                name: "ASUS RAM",
                price: 600,
                memoryType: "DDR5",
                memorySize: 16,
                frequency: 6000,
                nrSticks: 2);
        }

        public SSD GetSSD()
        {
            return new SSD(
                name: "ASUS SSD",
                price: 400,
                capacity: 1000,
                maxReadSpeed: 300,
                maxWriteSpeed: 500,
                format: "M.2");
        }
    }
}

using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Factories
{
    public class GigabyteFactory : IFactory
    {
        public Case GetCase()
        {
            return new Case(
                name: "Gigabyte Case",
                price: 300,
                format: "mATX",
                lateralPanelType: "solid",
                fansFront: 2,
                fansRear: 1);
        }

        public Cooler GetCooler()
        {
            return new Cooler(
                name: "Gigabyte Cooler",
                price: 150,
                type: "air");
        }

        public CPU GetCPU()
        {
            return new CPU(
                name: "Gigabyte CPU",
                price: 800,
                cores: 2,
                frequency: 3.2,
                power: 65);
        }

        public GPU GetGPU()
        {
            return new GPU(
                name: "Gigabyte GPU",
                price: 1500,
                memoryType: "GDDR6",
                memorySize: 8,
                fans: 1,
                portsHdmi: 1,
                portsDisplayPort: 2,
                power: 85);
        }

        public HDD GetHDD()
        {
            return new HDD(
                name: "Gigabyte HDD",
                price: 200,
                capacity: 2000,
                rpm: 7200,
                format: "3.5");
        }

        public Motherboard GetMotherboard()
        {
            return new Motherboard(
                name: "Gigabyte Motherboard",
                price: 400,
                hasIntegratedAudio: false);
        }

        public PowerSupply GetPowerSupply()
        {
            return new PowerSupply(
                name: "Gigabyte Power Supply",
                price: 500,
                power: 550,
                certification: "gold");
        }

        public RAM GetRAM()
        {
            return new RAM(
                name: "Gigabyte RAM",
                price: 300,
                memoryType: "DDR5",
                memorySize: 8,
                frequency: 48000,
                nrSticks: 1);
        }

        public SSD GetSSD()
        {
            return new SSD(
                name: "Gigabyte SSD",
                price: 600,
                capacity: 2000,
                maxReadSpeed: 300,
                maxWriteSpeed: 500,
                format: "M.2");
        }
    }
}

using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Factories
{
    public class MsiFactory : IFactory
    {
        public Case GetCase()
        {
            return new Case(
                name: "MSI Case",
                price: 600,
                format: "mATX",
                lateralPanelType: "solid",
                fansFront: 3,
                fansRear: 1);
        }

        public Cooler GetCooler()
        {
            return new Cooler(
                name: "MSI Cooler",
                price: 400,
                type: "watercooler");
        }

        public CPU GetCPU()
        {
            return new CPU(
                name: "MSI CPU",
                price: 1200,
                cores: 6,
                frequency: 3.6,
                power: 65);
        }

        public GPU GetGPU()
        {
            return new GPU(
                name: "MSI GPU",
                price: 2500,
                memoryType: "GDDR6",
                memorySize: 16,
                fans: 3,
                portsHdmi: 1,
                portsDisplayPort: 3,
                power: 165);
        }

        public HDD GetHDD()
        {
            return new HDD(
                name: "MSI HDD",
                price: 150,
                capacity: 1000,
                rpm: 10000,
                format: "3.5");
        }

        public Motherboard GetMotherboard()
        {
            return new Motherboard(
                name: "MSI Motherboard",
                price: 500,
                hasIntegratedAudio: true);
        }

        public PowerSupply GetPowerSupply()
        {
            return new PowerSupply(
                name: "MSI Power Supply",
                price: 500,
                power: 850,
                certification: "silver");
        }

        public RAM GetRAM()
        {
            return new RAM(
                name: "MSI RAM",
                price: 650,
                memoryType: "DDR5",
                memorySize: 32,
                frequency: 5200,
                nrSticks: 2);
        }

        public SSD GetSSD()
        {
            return new SSD(
                name: "MSI SSD",
                price: 200,
                capacity: 500,
                maxReadSpeed: 300,
                maxWriteSpeed: 500,
                format: "2.5");
        }
    }
}

using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Builders
{
    public class Builder
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

        public Builder()
        {

        }

        public Builder AddCase(Case caseCover)
        {
            this.caseCover = caseCover;
            return this;
        }

        public Builder AddCooler(Cooler cooler)
        {
            this.cooler = cooler;
            return this;
        }

        public Builder AddCPU(CPU cpu)
        {
            this.cpu = cpu;
            return this;
        }

        public Builder AddGPU(GPU gpu)
        {
            this.gpu = gpu;
            return this;
        }

        public Builder AddHDD(HDD hdd)
        {
            this.hdd = hdd;
            return this;
        }

        public Builder AddMotherboard (Motherboard motherboard)
        {
            this.motherboard = motherboard;
            return this;
        }

        public Builder AddPowerSupply(PowerSupply powersupply)
        {
            this.powersupply = powersupply;
            return this;
        }

        public Builder AddRAM(RAM ram)
        {
            this.ram = ram;
            return this;
        }

        public Builder AddSSD(SSD ssd)
        {
            this.ssd = ssd;
            return this;
        }

        public PC Build()
        {
            return new PC(caseCover, cooler, cpu, gpu, hdd, motherboard, powersupply, ram, ssd);
        }
    }
}

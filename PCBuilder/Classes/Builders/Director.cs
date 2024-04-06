using PCBuilder.Classes.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Classes.Builders
{
    public class Director
    {
        private AsusFactory asusFactory;
        private MsiFactory msiFactory;
        private GigabyteFactory gigabyteFactory;

        public Director()
        {
            asusFactory = new AsusFactory();
            msiFactory = new MsiFactory();
            gigabyteFactory = new GigabyteFactory();
        }

        public void BuildLowRangePC(Builder builder)
        {
            builder.AddCase(asusFactory.GetCase())
                   .AddMotherboard(asusFactory.GetMotherboard())
                   .AddRAM(gigabyteFactory.GetRAM())
                   .AddCPU(gigabyteFactory.GetCPU())
                   .AddCooler(gigabyteFactory.GetCooler())
                   .AddGPU(gigabyteFactory.GetGPU())
                   .AddPowerSupply(asusFactory.GetPowerSupply())
                   .AddHDD(asusFactory.GetHDD())
                   .AddSSD(asusFactory.GetSSD());
        }

        public void BuildMidRangePC(Builder builder)
        {
            builder.AddCase(asusFactory.GetCase())
                   .AddMotherboard(msiFactory.GetMotherboard())
                   .AddRAM(asusFactory.GetRAM())
                   .AddCPU(asusFactory.GetCPU())
                   .AddCooler(asusFactory.GetCooler())
                   .AddGPU(asusFactory.GetGPU())
                   .AddPowerSupply(asusFactory.GetPowerSupply())
                   .AddHDD(gigabyteFactory.GetHDD())
                   .AddSSD(gigabyteFactory.GetSSD());
        }

        public void BuildHighRangePC(Builder builder)
        {
            builder.AddCase(msiFactory.GetCase())
                   .AddMotherboard(msiFactory.GetMotherboard())
                   .AddRAM(msiFactory.GetRAM())
                   .AddCPU(msiFactory.GetCPU())
                   .AddCooler(msiFactory.GetCooler())
                   .AddGPU(msiFactory.GetGPU())
                   .AddPowerSupply(msiFactory.GetPowerSupply())
                   .AddHDD(msiFactory.GetHDD())
                   .AddSSD(msiFactory.GetSSD());
        }
    }
}

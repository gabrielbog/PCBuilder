using PCBuilder.Classes.Factories;
using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class GigabyteUnitTest
    {
        [Fact]
        public void GetCase_Case_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedCase = new Case(
                name: "Gigabyte Case",
                price: 300,
                format: "mATX",
                lateralPanelType: "solid",
                fansFront: 2,
                fansRear: 1);
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var factCase = gigabyteFactory.GetCase();

            //Assert
            Assert.Equal(expectedCase.name, factCase.name);
            Assert.Equal(expectedCase.price, factCase.price);
            Assert.Equal(expectedCase.format, factCase.format);
            Assert.Equal(expectedCase.lateralPanelType, factCase.lateralPanelType);
            Assert.Equal(expectedCase.fansFront, factCase.fansFront);
            Assert.Equal(expectedCase.fansRear, factCase.fansRear);
        }

        [Fact]
        public void GetCooler_Cooler_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedCooler = new Cooler(
                name: "Gigabyte Cooler",
                price: 150,
                type: "air");
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var cooler = gigabyteFactory.GetCooler();

            //Assert
            Assert.Equal(expectedCooler.name, cooler.name);
            Assert.Equal(expectedCooler.price, cooler.price);
            Assert.Equal(expectedCooler.type, cooler.type);
        }

        [Fact]
        public void GetCPU_CPU_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedCpu = new CPU(
                name: "Gigabyte CPU",
                price: 800,
                cores: 2,
                frequency: 3.2,
                power: 65);
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var cpu = gigabyteFactory.GetCPU();

            //Assert
            Assert.Equal(expectedCpu.name, cpu.name);
            Assert.Equal(expectedCpu.price, cpu.price);
            Assert.Equal(expectedCpu.cores, cpu.cores);
            Assert.Equal(expectedCpu.frequency, cpu.frequency);
            Assert.Equal(expectedCpu.power, cpu.power);
        }

        [Fact]
        public void GetGPU_GPU_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedGpu = new GPU(
                name: "Gigabyte GPU",
                price: 1500,
                memoryType: "GDDR6",
                memorySize: 8,
                fans: 1,
                portsHdmi: 1,
                portsDisplayPort: 2,
                power: 85);
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var gpu = gigabyteFactory.GetGPU();

            //Assert
            Assert.Equal(expectedGpu.name, gpu.name);
            Assert.Equal(expectedGpu.price, gpu.price);
            Assert.Equal(expectedGpu.memoryType, gpu.memoryType);
            Assert.Equal(expectedGpu.memorySize, gpu.memorySize);
            Assert.Equal(expectedGpu.fans, gpu.fans);
            Assert.Equal(expectedGpu.portsHdmi, gpu.portsHdmi);
            Assert.Equal(expectedGpu.portsDisplayPort, gpu.portsDisplayPort);
            Assert.Equal(expectedGpu.power, gpu.power);
        }

        [Fact]
        public void GetHDD_HDD_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedHdd = new HDD(
                name: "Gigabyte HDD",
                price: 200,
                capacity: 2000,
                rpm: 7200,
                format: "3.5");
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var hdd = gigabyteFactory.GetHDD();

            //Assert
            Assert.Equal(expectedHdd.name, hdd.name);
            Assert.Equal(expectedHdd.price, hdd.price);
            Assert.Equal(expectedHdd.capacity, hdd.capacity);
            Assert.Equal(expectedHdd.rpm, hdd.rpm);
            Assert.Equal(expectedHdd.format, hdd.format);
        }

        [Fact]
        public void GetMotherboard_Motherboard_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedMotherboard = new Motherboard(
                name: "Gigabyte Motherboard",
                price: 400,
                hasIntegratedAudio: false);
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var motherboard = gigabyteFactory.GetMotherboard();

            //Assert
            Assert.Equal(expectedMotherboard.name, motherboard.name);
            Assert.Equal(expectedMotherboard.price, motherboard.price);
            Assert.Equal(expectedMotherboard.hasIntegratedAudio, motherboard.hasIntegratedAudio);
        }

        [Fact]
        public void GetPowerSupply_PowerSupply_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedPowersupply = new PowerSupply(
                name: "Gigabyte Power Supply",
                price: 500,
                power: 550,
                certification: "gold");
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var powersupply = gigabyteFactory.GetPowerSupply();

            //Assert
            Assert.Equal(expectedPowersupply.name, powersupply.name);
            Assert.Equal(expectedPowersupply.price, powersupply.price);
            Assert.Equal(expectedPowersupply.power, powersupply.power);
            Assert.Equal(expectedPowersupply.certification, powersupply.certification);
        }

        [Fact]
        public void GetRAM_RAM_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedRam = new RAM(
                name: "Gigabyte RAM",
                price: 300,
                memoryType: "DDR5",
                memorySize: 8,
                frequency: 48000,
                nrSticks: 1);
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var ram = gigabyteFactory.GetRAM();

            //Assert
            Assert.Equal(expectedRam.name, ram.name);
            Assert.Equal(expectedRam.price, ram.price);
            Assert.Equal(expectedRam.memoryType, ram.memoryType);
            Assert.Equal(expectedRam.memorySize, ram.memorySize);
            Assert.Equal(expectedRam.frequency, ram.frequency);
            Assert.Equal(expectedRam.nrSticks, ram.nrSticks);
        }

        [Fact]
        public void GetSSD_SSD_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedSsd = new SSD(
                name: "Gigabyte SSD",
                price: 600,
                capacity: 2000,
                maxReadSpeed: 300,
                maxWriteSpeed: 500,
                format: "M.2");
            var gigabyteFactory = new GigabyteFactory();

            //Act
            var ssd = gigabyteFactory.GetSSD();

            //Assert
            Assert.Equal(expectedSsd.name, ssd.name);
            Assert.Equal(expectedSsd.price, ssd.price);
            Assert.Equal(expectedSsd.capacity, ssd.capacity);
            Assert.Equal(expectedSsd.maxReadSpeed, ssd.maxReadSpeed);
            Assert.Equal(expectedSsd.maxWriteSpeed, ssd.maxWriteSpeed);
            Assert.Equal(expectedSsd.format, ssd.format);
        }
    }
}

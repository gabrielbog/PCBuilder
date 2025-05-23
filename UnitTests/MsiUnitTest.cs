using PCBuilder.Classes.Factories;
using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class MsiUnitTest
    {
        [Fact]
        public void GetCase_Case_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedCase = new Case(
                name: "MSI Case",
                price: 600,
                format: "mATX",
                lateralPanelType: "solid",
                fansFront: 3,
                fansRear: 1);
            var msiFactory = new MsiFactory();

            //Act
            var factCase = msiFactory.GetCase();

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
                name: "MSI Cooler",
                price: 400,
                type: "watercooler");
            var msiFactory = new MsiFactory();

            //Act
            var cooler = msiFactory.GetCooler();

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
                name: "MSI CPU",
                price: 1200,
                cores: 6,
                frequency: 3.6,
                power: 65);
            var msiFactory = new MsiFactory();

            //Act
            var cpu = msiFactory.GetCPU();

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
                name: "MSI GPU",
                price: 2500,
                memoryType: "GDDR6",
                memorySize: 16,
                fans: 3,
                portsHdmi: 1,
                portsDisplayPort: 3,
                power: 165);
            var msiFactory = new MsiFactory();

            //Act
            var gpu = msiFactory.GetGPU();

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
                name: "MSI HDD",
                price: 150,
                capacity: 1000,
                rpm: 10000,
                format: "3.5");
            var msiFactory = new MsiFactory();

            //Act
            var hdd = msiFactory.GetHDD();

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
                name: "MSI Motherboard",
                price: 500,
                hasIntegratedAudio: true);
            var msiFactory = new MsiFactory();

            //Act
            var motherboard = msiFactory.GetMotherboard();

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
                name: "MSI Power Supply",
                price: 500,
                power: 850,
                certification: "silver");
            var msiFactory = new MsiFactory();

            //Act
            var powersupply = msiFactory.GetPowerSupply();

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
                name: "MSI RAM",
                price: 650,
                memoryType: "DDR5",
                memorySize: 32,
                frequency: 5200,
                nrSticks: 2);
            var msiFactory = new MsiFactory();

            //Act
            var ram = msiFactory.GetRAM();

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
                name: "MSI SSD",
                price: 200,
                capacity: 500,
                maxReadSpeed: 300,
                maxWriteSpeed: 500,
                format: "2.5");
            var msiFactory = new MsiFactory();

            //Act
            var ssd = msiFactory.GetSSD();

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

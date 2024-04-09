using PCBuilder.Classes.Factories;
using PCBuilder.Classes.Products;

namespace UnitTests
{
    public class AsusUnitTest
    {
        [Fact]
        public void GetCase_Case_ReturnsCorrectConfiguration()
        {
            //Arrange
            var expectedCase = new Case(
                name: "ASUS Case",
                price: 500,
                format: "mATX",
                lateralPanelType: "glass",
                fansFront: 2,
                fansRear: 0);
            var asusFactory = new AsusFactory();

            //Act
            var factCase = asusFactory.GetCase();

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
                name: "ASUS Cooler",
                price: 200,
                type: "air");
            var asusFactory = new AsusFactory();

            //Act
            var cooler = asusFactory.GetCooler();

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
                name: "ASUS CPU",
                price: 1000,
                cores: 4,
                frequency: 3.6,
                power: 105);
            var asusFactory = new AsusFactory();

            //Act
            var cpu = asusFactory.GetCPU();

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
                name: "ASUS GPU",
                price: 2000,
                memoryType: "GDDR6",
                memorySize: 8,
                fans: 2,
                portsHdmi: 2,
                portsDisplayPort: 2,
                power: 165);
            var asusFactory = new AsusFactory();

            //Act
            var gpu = asusFactory.GetGPU();

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
                name: "ASUS HDD",
                price: 100,
                capacity: 1000,
                rpm: 7200,
                format: "3.5");
            var asusFactory = new AsusFactory();

            //Act
            var hdd = asusFactory.GetHDD();

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
                name: "ASUS Motherboard",
                price: 400,
                hasIntegratedAudio: false);
            var asusFactory = new AsusFactory();

            //Act
            var motherboard = asusFactory.GetMotherboard();

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
                name: "ASUS Power Supply",
                price: 400,
                power: 750,
                certification: "bronze");
            var asusFactory = new AsusFactory();

            //Act
            var powersupply = asusFactory.GetPowerSupply();

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
                name: "ASUS RAM",
                price: 600,
                memoryType: "DDR5",
                memorySize: 16,
                frequency: 6000,
                nrSticks: 2);
            var asusFactory = new AsusFactory();

            //Act
            var ram = asusFactory.GetRAM();

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
                name: "ASUS SSD",
                price: 400,
                capacity: 1000,
                maxReadSpeed: 300,
                maxWriteSpeed: 500,
                format: "M.2");
            var asusFactory = new AsusFactory();

            //Act
            var ssd = asusFactory.GetSSD();

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
using PCBuilder.Classes.Factories;
using PCBuilder.Classes.Menu;
using PCBuilder.Classes.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class MenuUnitTest
    {
        [Fact]
        public void GetInstance_Menu_ReturnsSameInstance()
        {
            //Arrange
            var expectedInstance = Menu.GetInstance();

            //Act
            var instance = Menu.GetInstance();

            //Assert
            Assert.Equal(expectedInstance, instance);
        }
    }
}

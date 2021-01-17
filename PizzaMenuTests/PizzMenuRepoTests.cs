using System.Collections.Generic;
using PizzaMenu.Repositories;
using Moq;
using Xunit;
using PizzaMenu.Models;

namespace PizzaMenuTests
{
    public class PizzaMenuRepoTests
    {
        private readonly Mock<IMenuItemRepository> mockMenuRepo;
        private readonly IMenuItemRepository menuRepo;

        public PizzaMenuRepoTests()
        {
            mockMenuRepo = new Mock<IMenuItemRepository>();

            var testItem = new MenuItem
            {
                Id = 1,
                Name = "TestItem",
                Active = true
            };

            var testMenuList = new List<MenuItem>
            {
                testItem
            };

            mockMenuRepo.Setup(m =>m.GetItems()).Returns(testMenuList);
            menuRepo = mockMenuRepo.Object;
        }
        [Fact]
        public void GetItemsReturnsAlist()
        {
            //Act
            List<MenuItem> result;
            //Arrange
            result = menuRepo.GetItems();
            //Assert
            Assert.IsType<List<MenuItem>>(result);
        }
        [Fact]
        public void GetItemsReturnsIsNotEmpty()
        {
            //Act
            List<MenuItem> result;
            //Arrange
            result = menuRepo.GetItems();
            //Assert
            Assert.NotEmpty(result);
            Assert.Equal("TestItem", result[0].Name);
        }
        
    }
}

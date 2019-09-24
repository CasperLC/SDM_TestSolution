using System.Linq;
using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Project.TDD_Exercise2;

namespace SDM_ProjectTests
{
    [TestClass]
    public class TDD_Exercise2_Tests
    {
        [TestMethod]
        public void CreateShopGetShop_Test()
        {
            //Arrange
            ShopCollection shops = new ShopCollection();
            Shop shopExpected = new Shop()
            {
                Address = "123",
                Id = 1,
                Name = "asdads",
                Website = "www.123.com",
                gpsX = 5,
                gpsY = 5
            };
            //Act
            shops.CreateShop(shopExpected);
            Shop shopActual = shops.ReaedShop(1);

            //Assert
            Assert.AreEqual(shopExpected,shopActual);
        }

        [TestMethod]
        public void AllShops_Tests()
        {
            var shops = new ShopCollection();

            var shopOne = new Shop()
            {
                Address = "123",
                Id = 1,
                Name = "asdads",
                Website = "www.123.com",
                gpsX = 2,
                gpsY = 2
            };
            var shopTwo = new Shop()
            {
                Address = "456",
                Id = 2,
                Name = "qweqwe",
                Website = "www.456.com",
                gpsX = 5,
                gpsY = 5
            };
            var shopThree = new Shop()
            {
                Address = "789",
                Id = 3,
                Name = "zxczxc",
                Website = "www.789.com",
                gpsX = 8,
                gpsY = 8
            };
            var shopFour = new Shop()
            {
                Address = "889",
                Id = 4,
                Name = "zxc3zxc",
                Website = "www.7829.com",
                gpsX = 10,
                gpsY = 10
            };
            var shopFive = new Shop()
            {
                Address = "7989",
                Id = 5,
                Name = "z23xczxc",
                Website = "www.78923.com",
                gpsX = 12,
                gpsY = 12
            };

            var paramX = 1;
            var paramY = 1;

            shops.CreateShop(shopTwo);
            shops.CreateShop(shopOne);
            shops.CreateShop(shopThree);
            shops.CreateShop(shopFive);
            shops.CreateShop(shopFour);

            Assert.AreEqual(shopOne,shops.AllShops(paramX,paramY).FirstOrDefault());
            Assert.AreEqual(shopThree,shops.AllShops(paramX,paramY)[2]);
            Assert.AreEqual(shopFive, shops.AllShops(paramX,paramY)[4]);
        }

        [TestMethod]
        public void FilteredShops_Test()
        {
            var shops = new ShopCollection();

            var shopOne = new Shop()
            {
                Address = "123",
                Id = 1,
                Name = "asdads",
                Website = "www.123.com",
                gpsX = 2,
                gpsY = 2
            };
            var shopTwo = new Shop()
            {
                Address = "456",
                Id = 2,
                Name = "qweqwe",
                Website = "www.456.com",
                gpsX = 6,
                gpsY = 6
            };

            shops.CreateShop(shopOne);
            shops.CreateShop(shopTwo);

            Assert.AreEqual(shopOne, shops.FilteredShops(1, 1, 4, 4).FirstOrDefault());
            Assert.AreEqual(1, shops.FilteredShops(1, 1, 4, 4).Count);
        }
        
    }
}
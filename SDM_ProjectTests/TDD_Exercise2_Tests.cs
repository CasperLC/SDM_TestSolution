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

            var paramX = 1;
            var paramY = 1;

            shops.CreateShop(shopTwo);
            shops.CreateShop(shopOne);
            shops.CreateShop(shopThree);

            Assert.AreEqual(shopOne,shops.AllShops(paramX,paramY).FirstOrDefault());



        }
        
    }
}
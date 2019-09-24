using System;
using SDM_Project.TDD_Exercise2;

namespace SDM_Project
{
    class Program
    {
        static void Main(string[] args)
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

            shops.CreateShop(shopTwo);
            shops.CreateShop(shopOne);
            shops.CreateShop(shopThree);

            shops.AllShops(1, 1);
        }
    }
}

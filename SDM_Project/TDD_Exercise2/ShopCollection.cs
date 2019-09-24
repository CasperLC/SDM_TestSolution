using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SDM_Project.TDD_Exercise2
{
    public class ShopCollection : IShopCollection
    {

        public List<Shop> Shops = new List<Shop>();

        public void CreateShop(Shop shop)
        {
            Shops.Add(shop);
        }

        public void RemoveShop(Shop shop)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateShop(Shop shop)
        {
            throw new System.NotImplementedException();
        }

        public Shop ReaedShop(int id)
        {
            return Shops.FirstOrDefault(s => s.Id == id);
        }

        public List<Shop> AllShops(int x, int y)
        {
            int location = x + y;
            int[,] sup = new int[Shops.Count, 2];
            List<Shop> sortedShops = new List<Shop>();
            for (int i = 0; i < Shops.Count; i++)
            {
                int distance = location - (Shops[i].gpsX + Shops[i].gpsY);
                if (distance < 0)
                {
                    distance = (Shops[i].gpsX + Shops[i].gpsY) - location;
                }

                sup[i, 0] = Shops[i].Id;
                sup[i, 1] = distance;
            }

            Shop tempShop = new Shop();
            List<Shop> tempList = new List<Shop>();
            tempList = Shops;
            int count = Shops.Count;
            bool isThisFirst = true;
            int temp = int.MaxValue;
            int temp2 = int.MaxValue;

            for (int ip = 0; ip < count; ip++)
            {
                for (int i = 0; i < count; i++)
                {
                    if (isThisFirst)
                    {
                        if (sup[i, 1] < temp)
                        {
                            temp = sup[i, 1];
                            tempShop = Shops.FirstOrDefault(s => s.Id == sup[i, 0]);
                        }

                    }
                    else
                    {
                        if (sup[i, 1] > temp && sup[i,1] < temp2)
                        {
                            temp2 = sup[i, 1];
                            tempShop = Shops.FirstOrDefault(s => s.Id == sup[i, 0]);
                        }
                    }

                }

                if (isThisFirst)
                {
                    isThisFirst = false;

                }
                else
                {
                    temp = temp2;
                    temp2 = int.MaxValue;
                }


                sortedShops.Add(tempShop);
            }
            

            return sortedShops;

        }

        public List<Shop> FilteredShops(int x, int y, int x2, int y2)
        {
            List<Shop> filtered = new List<Shop>();
            int pointX;
            int pointY;
            int pointX2;
            int pointY2;

            if (x < x2)
            {
                pointX = x;
                pointX2 = x2;
            }
            else
            {
                pointX = x2;
                pointX2 = x;
            }

            if (y < y2)
            {
                pointY = y;
                pointY2 = y2;
            }
            else
            {
                pointY = y2;
                pointY2 = y;
            }


            foreach (var shop in Shops)
            {
                if ((shop.gpsX >= pointX && shop.gpsX <= pointX2) && (shop.gpsY >= pointY && shop.gpsY <= pointY2))
                {
                    filtered.Add(shop);
                }
            }



            return filtered;
        }
    }
}
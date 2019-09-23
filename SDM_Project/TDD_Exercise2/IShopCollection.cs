using System.Collections.Generic;

namespace SDM_Project.TDD_Exercise2
{
    public interface IShopCollection
    {
        void CreateShop(Shop shop);

        void RemoveShop(Shop shop);

        void UpdateShop(Shop shop);

        Shop ReaedShop(int id);

        List<Shop> AllShops(int x, int y);

        List<Shop> FilteredShops(int x, int y, int x2, int y2);


    }
}
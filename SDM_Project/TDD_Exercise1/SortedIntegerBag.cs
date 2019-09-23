using System.Collections.Generic;

namespace SDM_Project
{
    public class SortedIntegerBag: ISortedIntegerBag
    {
        private List<int> Bag = new List<int>();

        public void AddIntToBag(int x)
        {
            Bag.Add(x);
        }

        public void RemoveIntFromBag()
        {
            int temp = int.MaxValue;
            foreach (var item in Bag)
            {
                if (item < temp)
                {
                    temp = item;
                }
            }

            Bag.Remove(temp);
        }

        public int GetIntFromBag()
        {
            int temp = int.MaxValue;
            foreach (var item in Bag)
            {
                if (item < temp)
                {
                    temp = item;
                }
            }
            return temp;
        }

        public int CountIntInBag()
        {
            return Bag.Count;
        }
    }
}
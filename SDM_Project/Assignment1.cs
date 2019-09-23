using System.Globalization;

namespace SDM_Project
{
    public class Assignment1
    {
        public bool HasMajority(int[] a)
        {
            int count = 0;
            foreach (var num in a)
            {
                foreach (var check in a)
                {
                    if (num == check)
                    {
                        count++;
                    }
                }

                if (count > a.Length / 2)
                {
                    return true;
                }
                else
                {
                    count = 0;
                }
            }

            return false;
        }
    }
}
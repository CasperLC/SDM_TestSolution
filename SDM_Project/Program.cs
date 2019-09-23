using System;

namespace SDM_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Assignment1 test1 = new Assignment1();

            int[] a = new int[]
            {
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,5,2,2,
                1,3,4,5,2,2,2,2,2,2,
                1,3,4,5,2,2,2,2,2,2,
                1,3,4,5,2,2,2,2,2,2,
                1,3,4,5,2,2,2,2,2,2,
                1,3,4,5,2,2,2,2,2,2,
                1,3,4,5,2,2,2,2,2,2
            };

            Console.WriteLine(test1.HasMajority(a));
        }
    }
}

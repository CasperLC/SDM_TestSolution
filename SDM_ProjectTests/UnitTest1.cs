using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Project;

namespace SDM_ProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Assignment1_WithMajorityNumber()
        {
            //Arrange
            int[] testArray =
            {
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3
            };
            bool HasAMajorityNumber;
            Assignment1 ass1 = new Assignment1();

            //Act and Assert
            Assert.IsTrue(ass1.HasMajority(testArray),"wrong");

        }

        [TestMethod]
        public void TestAssigment1_WithoutMajority()
        {
            //Arrange
            int[] testArray =
            {
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,
                3,1,3,2,3,4,3,9,3,7,3,8,3,5,3,2,2
            };
            bool HasAMajorityNumber;
            Assignment1 ass1 = new Assignment1();

            //Act and Assert
            Assert.IsFalse(ass1.HasMajority(testArray), "wrong");
        }

    }
}

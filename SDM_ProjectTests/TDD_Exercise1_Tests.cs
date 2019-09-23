using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Project;

namespace SDM_ProjectTests
{
    [TestClass]
    public class TDD_Exercise1_Tests
    {
        [TestMethod]
        public void AddAndGetToIntegerBagTest()
        {
            //Arrange
            int x = 5;
            SortedIntegerBag bag = new SortedIntegerBag();

            //Act
            bag.AddIntToBag(x);
            var y = bag.GetIntFromBag();

            //Assert
            Assert.AreEqual(5,y);

        }

        [TestMethod]
        public void RemoveFromIntegerBagTest()
        {
            SortedIntegerBag bag = new SortedIntegerBag();
            bag.AddIntToBag(1);
            bag.AddIntToBag(2);
            bag.AddIntToBag(3);

            bag.RemoveIntFromBag();

            Assert.AreEqual(2,bag.GetIntFromBag());
        }

        [TestMethod]
        public void CountFromIntegerBagTest()
        {
            SortedIntegerBag bag = new SortedIntegerBag();
            bag.AddIntToBag(1);
            bag.AddIntToBag(2);
            bag.AddIntToBag(3);

            var x = bag.CountIntInBag();

            Assert.AreEqual(3,x);
        }
        
    }
}
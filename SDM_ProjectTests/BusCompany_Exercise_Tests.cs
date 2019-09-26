using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Project.BusCompany_Exercise;

namespace SDM_ProjectTests
{
    [TestClass]
    public class BusCompany_Exercise_Tests
    {

        [TestMethod]
        public void TotalCostInitialFee_Test()
        {
            var bus = new BusCompany();

            var actualCost = bus.TotalCost(0, 0);

            Assert.AreEqual(130,actualCost);
        }

        [TestMethod]
        public void TotalCostBelow100Km_Test()
        {
            var bus = new BusCompany();

            //Number of passengers doesn't matter, kilometers below 100 at rate 3.2 pr. km
            var actualCost = bus.TotalCost(1000, 99);

            Assert.AreEqual(316.8+130,actualCost);
        }

        [TestMethod]
        public void TotalCost100to500km_Test()
        {
            var bus = new BusCompany();

            //Kilometers above 100 and below 500, if below 12 passengers rate is 2.75, otherwise rate is 3.00
            var actualCost1 = bus.TotalCost(12, 150);

            var actualCost2 = bus.TotalCost(11, 150);

            //Assert with Above 12 Passengers
            Assert.AreEqual(450+130,actualCost1);
            //Assert with Below 12 Passengers
            Assert.AreEqual(412.5+130,actualCost2);
        }

    }
}
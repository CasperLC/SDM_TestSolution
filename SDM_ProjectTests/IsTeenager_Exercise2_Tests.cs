using Microsoft.VisualStudio.TestTools.UnitTesting;
using SDM_Project.Exercose2_IsTeenager;
using System;
using System.Collections.Generic;
using System.Text;

namespace SDM_ProjectTests
{
    [TestClass]
    public class IsTeenager_Exercise2_Tests
    {
        [TestMethod]
        public void isTeenager_Test()
        {
            var teen = new Teenager();

            var upperYear = DateTime.Today.Year - 15;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void isTeenager_UpperBound_Test()
        {
            var teen = new Teenager();

            //Subtracts 20 Years from today, then adds 1 day, essentially making it 19 Years & 364 Days
            var upperYear = DateTime.Today.Year - 20;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day + 1;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void isTeenager_InsideUpperBound_Test()
        {
            var teen = new Teenager();
            //Subtracts 20 Years from today, then adds 2 days
            var upperYear = DateTime.Today.Year - 20;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day + 2;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void isTeenager_OutsideUpperBound_Test()
        {
            var teen = new Teenager();
            //Subtracts 20 Years from today
            var upperYear = DateTime.Today.Year - 20;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void isTeenager_LowerBound_Test()
        {
            var teen = new Teenager();

            //Subtracts 13 Years from today
            var upperYear = DateTime.Today.Year - 13;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsTrue(actual);

        }

        [TestMethod]
        public void isTeenager_InsideLowerBound_Test()
        {
            var teen = new Teenager();

            //Subtracts 13 Years as well as 1 Day from Today, making the parameter 13 years and 1 day ago.
            var upperYear = DateTime.Today.Year - 13;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day-1;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void isTeenager_OutsideLowerBound_Test()
        {
            var teen = new Teenager();

            //Subtracts 13 Years from today, then adds 1 day. Making the paramter 12 years and 364 days ago.
            var upperYear = DateTime.Today.Year - 13;
            var upperMonth = DateTime.Today.Month;
            var upperDay = DateTime.Today.Day + 1;

            var birthday = DateTime.Parse($"{upperDay}/{upperMonth}/{upperYear}");

            var actual = teen.isTeenager(birthday);

            Assert.IsFalse(actual);
        }
    }
}

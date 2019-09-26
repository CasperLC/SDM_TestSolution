using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using SDM_Project.Exercise1_ToGrade;
using System.IO;

namespace SDM_ProjectTests
{
    [TestClass]
    public class Grade_Exercise1_Tests
    {
        [TestMethod]
        public void ToGrade_NegativeThree_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(3);
            var expected = -3;

            Assert.IsTrue(actual == expected);
            
        }

        [TestMethod]
        public void To_Grade_NegativeThree_LowerBoundary_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(0);
            var expected = -3;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_NegativeThree_InsideLowerBoundary_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(1);
            var expected = -3;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException), "Percentage can not be negative")]
        public void To_Grade_NegativeThree_OutsideLowerBoundary_Test()
        {
            var grade = new Grade();
            var actual = grade.ToGrade(-1);
        }

        [TestMethod]
        public void To_Grade_NegativeThree_UpperBoundary_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(5);
            var expected = -3;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_NegativeThree_InsideUpperBoundary_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(4);
            var expected = -3;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_NegativeThree_OutsideBoundary_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(6);
            var expected = -3;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(35);
            var expected = 0;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_LowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(6);
            var expected = 0;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_InsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(7);
            var expected = 0;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_OutsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(5);
            var expected = 0;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_UpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(49);
            var expected = 0;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_InsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(48);
            var expected = 0;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Zero_OutsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(50);
            var expected = 0;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(55);
            var expected = 2;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_LowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(50);
            var expected = 2;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_InsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(51);
            var expected = 2;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_OutsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(49);
            var expected = 2;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_UpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(59);
            var expected = 2;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_InsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(58);
            var expected = 2;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Two_OutsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(60);
            var expected = 2;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(70);
            var expected = 4;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_LowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(60);
            var expected = 4;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_InsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(61);
            var expected = 4;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_OutsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(59);
            var expected = 4;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_UpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(79);
            var expected = 4;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_InsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(78);
            var expected = 4;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Four_OutsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(80);
            var expected = 4;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(82);
            var expected = 7;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_LowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(80);
            var expected = 7;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_InsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(81);
            var expected = 7;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_OutsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(79);
            var expected = 7;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_UpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(84);
            var expected = 7;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_InsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(83);
            var expected = 7;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Seven_OutsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(85);
            var expected = 7;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(89);
            var expected = 10;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_LowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(85);
            var expected = 10;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_InsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(86);
            var expected = 10;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_OutsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(84);
            var expected = 10;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_UpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(94);
            var expected = 10;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_InsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(93);
            var expected = 10;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Ten_OutsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(95);
            var expected = 10;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Twelve_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(97);
            var expected = 12;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Twelve_LowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(95);
            var expected = 12;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Twelve_InsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(96);
            var expected = 12;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Twelve_OutsideLowerBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(94);
            var expected = 12;

            Assert.IsFalse(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Twelve_UpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(100);
            var expected = 12;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        public void To_Grade_Twelve_InsideUpperBound_Test()
        {
            var grade = new Grade();

            var actual = grade.ToGrade(99);
            var expected = 12;

            Assert.IsTrue(actual == expected);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidDataException),"Percentage given was above 100")]
        public void To_Grade_Twelve_OutsideUpperBound_Test()
        {
            var grade = new Grade();
            var actual = grade.ToGrade(101);
        }
    }
}

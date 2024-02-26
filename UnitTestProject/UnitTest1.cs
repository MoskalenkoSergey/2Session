using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTests
    {
        // Тестовые методы низкой сложности

        [TestMethod]
        public void CheckMarkCorrectly()
        {
            string mark = "X345AT152";
            bool actual = Class.CheckMark(mark);
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void CheckMarkNotCorrectly()
        {
            string mark = "X345AT000";
            bool actual = Class.CheckMark(mark);
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void GetNextMarkAfterCorrectly()
        {
            string exception = "B001BA152";
            string mark = "A999BX152";
            string actual = Class.GetNextMarkAfter(mark);
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetNextMarkAfterNotCorrectly()
        {
            string exception = "A006AA152";
            string mark = "A004AA152";
            string actual = Class.GetNextMarkAfter(mark);
            Assert.IsFalse(exception == actual);
        }

        [TestMethod]
        public void GetNextMarkAfterNotNull()
        {
            string mark = "A210XT152";
            string actual = Class.GetNextMarkAfter(mark);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void GetNextMarkAfterInRangeCorrectly()
        {
            string exception = "A006AA152";
            string prevMark = "A005AA152";
            string rangeStart = "A001AA152";
            string rangeEnd = "A800AB152";
            string actual = Class.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.IsTrue(exception == actual);
        }

        [TestMethod]
        public void GetNextMarkAfterInRangeCorrectlyType()
        {
            string prevMark = "A005AA152";
            string rangeStart = "A001AA152";
            string rangeEnd = "A800AB152";
            string actual = Class.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.IsInstanceOfType(actual, typeof(string));
        }

        [TestMethod]
        public void GetCombinationsCountInRangeCorrectly()
        {
            int exception = 1009;
            string mark1 = "A001AA152";
            string mark2 = "A010AB152";
            int actual = Class.GetCombinationsCountInRange(mark1, mark2);
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetCombinationsCountInRangeNotCorrectly()
        {
            int exception = 150;
            string mark1 = "A001AA152";
            string mark2 = "A010AA152";
            int actual = Class.GetCombinationsCountInRange(mark1, mark2);
            Assert.IsTrue(exception != actual);
        }

        [TestMethod]
        public void GetCombinationsCountInRangeTypeCorrectly()
        {
            string mark1 = "A001AA152";
            string mark2 = "A010AB152";
            int actual = Class.GetCombinationsCountInRange(mark1, mark2);
            Assert.IsInstanceOfType(actual, typeof(int));
        }


        // Методы высокой сложности

        [TestMethod]
        public void CheckMarkCorrectlyType()
        {
            string mark = "A000AA152";
            bool actual = Class.CheckMark(mark);
            Assert.IsInstanceOfType(actual, typeof(bool));
        }

        [TestMethod]
        public void GetNextMarkAfterBorder()
        {
            string exception = "Ошибка";
            string mark = "X999XX152";
            string actual = Class.GetNextMarkAfter(mark);
            Assert.IsTrue(exception == actual);
        }

        public void GetNextMarkAfterInRangeNotCorrectlyRegion()
        {
            string exception = "OutOfStock";
            string prevMark = "A005AA777";
            string rangeStart = "A001AA155";
            string rangeEnd = "A800AB155";
            string actual = Class.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.AreEqual(exception, actual);
        }

        [TestMethod]
        public void GetNextMarkAfterInRangeNotCorrectly()
        {
            string exception = "OutOfStock";
            string prevMark = "A990AB152";
            string rangeStart = "A001AA152";
            string rangeEnd = "A800AB152";
            string actual = Class.GetNextMarkAfterInRange(prevMark, rangeStart, rangeEnd);
            Assert.IsTrue(exception == actual);
        }

        [TestMethod]
        public void CheckMarkNotCorrectlyRegion()
        {
            bool exception = false;
            string mark = "X345AT000";
            bool actual = Class.CheckMark(mark);
            Assert.AreEqual(exception, actual);
        }
    }
}

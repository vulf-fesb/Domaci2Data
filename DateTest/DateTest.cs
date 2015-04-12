using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DateNs;

namespace DateTest
{
    [TestClass]
    public class DateTest
    {
        [TestMethod]
        public void TestIsLeapYearForLeapYear()
        {
            var date = new Date(20, 11, 1996);

            Assert.AreEqual(true,date.isLeapYear(),"Leap year should return true");
        }

        [TestMethod]
        public void TestIsLeapYearForNonLeapYearNormal()
        {
            var date = new Date(20, 11, 2015);

            Assert.AreEqual(false, date.isLeapYear(), "Non leap year should return false");
        }

        [TestMethod]
        public void TestIsLeapYearForNonLeapYearMod400()
        {
            var date = new Date(20, 11, 2000);

            Assert.AreEqual(true, date.isLeapYear(), "Leap year should return true");
        }

        [TestMethod]
        public void TestIsLeapYearForNonLeapMod100()
        {
            var date = new Date(20,11,1900);
            
            Assert.AreEqual(false,date.isLeapYear(), "Non leap year should return false");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth1()
        {
            var date = new Date(20, 1, 2015);

            Assert.AreEqual("January", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth2()
        {
            var date = new Date(20, 2, 2015);

            Assert.AreEqual("February", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth3()
        {
            var date = new Date(20, 3, 2015);

            Assert.AreEqual("March", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth4()
        {
            var date = new Date(20, 4, 2015);

            Assert.AreEqual("April", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth5()
        {
            var date = new Date(20, 5, 2015);

            Assert.AreEqual("May", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth6()
        {
            var date = new Date(20, 6, 2015);

            Assert.AreEqual("June", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth7()
        {
            var date = new Date(20, 7, 2015);

            Assert.AreEqual("July", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth8()
        {
            var date = new Date(20, 8, 2015);

            Assert.AreEqual("August", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth9()
        {
            var date = new Date(20, 9, 2015);

            Assert.AreEqual("September", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth10()
        {
            var date = new Date(20, 10, 2015);

            Assert.AreEqual("October", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth11()
        {
            var date = new Date(20, 11, 2015);

            Assert.AreEqual("November", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetMonthNameShouldReturnCorrectMonth12()
        {
            var date = new Date(20, 12, 2015);

            Assert.AreEqual("December", date.getMonthName(), "Incorrect month returned");
        }

        [TestMethod]
        public void GetNumberOfRemainingDays31()
        {
            var date = new Date(20, 3, 2015);

            Assert.AreEqual((uint)11, date.getNumberOfRemainingDaysInMonth(), "Incorrect number of days returned");
        }

        [TestMethod]
        public void GetNumberOfRemainingDays30()
        {
            var date = new Date(20, 4, 2015);

            Assert.AreEqual((uint)10, date.getNumberOfRemainingDaysInMonth(), "Incorrect number of days returned");
        }

        [TestMethod]
        public void GetNumberOfRemainingDays28()
        {
            var date = new Date(20, 2, 2015);

            Assert.AreEqual((uint)8, date.getNumberOfRemainingDaysInMonth(), "Incorrect number of days returned");
        }

        [TestMethod]
        public void GetNumberOfRemainingDays29()
        {
            var date = new Date(20, 2, 2004);

            Assert.AreEqual((uint)9, date.getNumberOfRemainingDaysInMonth(), "Incorrect number of days returned");
        }

        [TestMethod]
        public void GetNumberOfRemainingDays14()
        {
            var date = new Date(20, 14, 2004);

            Assert.AreEqual((uint)0, date.getNumberOfRemainingDaysInMonth(), "Incorrect number of days returned");
        }

        [TestMethod]
        public void WrongDateEntered31()
        {
            var date = new Date(32, 1, 2015);
        }

        [TestMethod]
        public void WrongDateEntered30()
        {
            var date = new Date(32, 4, 2015);
        }

        [TestMethod]
        public void WrongDateEntered29()
        {
            var date = new Date(32, 2, 2004);
        }

        [TestMethod]
        public void WrongDateEntered28()
        {
            var date = new Date(32, 2, 2015);
        }
    }
}

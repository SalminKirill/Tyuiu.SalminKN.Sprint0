using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SalminKN.Sprint0.Task5.V0.Lib;

namespace Tyuiu.SalminKN.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAddtictionMethod()
        {
            Assert.AreEqual(10, DataService.Addiction(5, 5));
        }
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substraction(10, 5));
        }
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(5, DataService.Multiplication(10, 5));
        }
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(1, DataService.Division(5, 5));
        }
    }
}

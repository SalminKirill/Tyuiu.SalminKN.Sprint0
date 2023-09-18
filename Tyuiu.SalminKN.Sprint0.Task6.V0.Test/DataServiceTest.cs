using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SalminKN.Sprint0.Task6.V0.Lib;

namespace Tyuiu.SalminKN.Sprint0.Task6.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArrayValid()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.AddictionArray(numbers);
            Assert.AreEqual(15, res);
        }
        public void CheckSubstractionArrayValid()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.SubstractionArray(numbers);
            Assert.AreEqual(-15, res);
        }
        public void CheckMultArrayValid()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var res = DataService.MultiplicationArray(numbers);
            Assert.AreEqual(100, res);
        }
    }
}

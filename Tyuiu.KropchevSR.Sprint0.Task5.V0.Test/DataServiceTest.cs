using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography.X509Certificates;

using Tyuiu.KropchevSR.Sprint0.Task5.V0.Lib;


namespace Tyuiu.KropchevSR.Sprint0.Task5.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        [TestMethod]
        public void CheckedSubstractionValid()
        {
            Assert.AreEqual(5, DataService.Substration(10, 5));
        }

        [TestMethod]
        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        [TestMethod]
        public void CheckedDivisionValid()
        {
            Assert.AreEqual(2, DataService.Division(10, 5));
        }
    }
}

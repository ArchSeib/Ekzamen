using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private bool ExpectedTrue = true;
        private bool ExpectedFalse = false;
        [TestMethod]
        public void TestMethod11()
        {
            String check = "";
            var result = Ekzamen.MainWindow.CheckEmpty(check);
            Assert.AreEqual(ExpectedFalse, result);
        }
        [TestMethod]
        public void TestMethod12()
        {
            String check = "erewrrwe ewrwerwe wer";
            var result = Ekzamen.MainWindow.CheckEmpty(check);
            Assert.AreEqual(ExpectedTrue, result);
        }
        [TestMethod]
        public void TestMethod21()
        {
            String check = "123456789";
            var result = Ekzamen.MainWindow.CheckAuthor(check);
            Assert.AreEqual(ExpectedFalse, result);
        }
        [TestMethod]
        public void TestMethod22()
        {
            String check = "1234567890123456789012";
            var result = Ekzamen.MainWindow.CheckAuthor(check);
            Assert.AreEqual(ExpectedTrue, result);
        }
        [TestMethod]
        public void TestMethod31()
        {
            String check = "12452532";
            var result = Ekzamen.MainWindow.CheckName(check);
            Assert.AreEqual(ExpectedFalse, result);
        }
        public void TestMethod32()
        {
            String check = "12345678901";
            var result = Ekzamen.MainWindow.CheckName(check);
            Assert.AreEqual(ExpectedTrue, result);
        }
        [TestMethod]
        public void TestMethod41()
        {
            String check = "____";
            var result = Ekzamen.MainWindow.CheckYearEmpty(check);
            Assert.AreEqual(ExpectedFalse, result);
        }
        [TestMethod]
        public void TestMethod42()
        {
            String check = "_334";
            var result = Ekzamen.MainWindow.CheckYearEmpty(check);
            Assert.AreEqual(ExpectedTrue, result);
        }
        [TestMethod]
        public void TestMethod51()
        {
            String check = "232";
            var result = Ekzamen.MainWindow.CheckYear(check);
            Assert.AreEqual(ExpectedFalse, result);
        }
        [TestMethod]
        public void TestMethod52()
        {
            String check = "2001";
            var result = Ekzamen.MainWindow.CheckYear(check);
            Assert.AreEqual(ExpectedTrue, result);
        }
    }
}

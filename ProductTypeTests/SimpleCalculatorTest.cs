using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel;
using WindowsFormsApp1;
namespace ProductTypeTests
{
    [TestClass]

    public class SimpleCalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int angka1 = 3;
            int angka2 = 1;
            string operasi = "+";
            double expected =  -7;
            SimpleCalculator cs = new SimpleCalculator(angka1, angka2, operasi);
            Assert.AreEqual(expected, cs.hitung());
        }
    }
}

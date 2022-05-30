using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;
using System;

namespace TemperatureConvertersTests
{
    [TestClass]
    public class FarenheitConvertersTests
    {


        FarenheitConverter _farenheitConverter = new FarenheitConverter();

        [TestMethod]
        [DataRow(233.15, -40)]
        [DataRow(100, -279.67)]
        [DataRow(-180, -783.67)]
        public void test_Farenheit_fromKelvintoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_farenheitConverter.fromKelvintoSelf(temp), 2));

        }

        [TestMethod]
        [DataRow(100,100)]
        [DataRow(92.70, 92.7)]
        [DataRow(-100, -100)]
        public void test_Farenheit_fromFarenheittoSelf(double temp, double expected) {
            Assert.AreEqual(expected, Math.Round(_farenheitConverter.fromFarenheittoSelf(temp),2));

        }

        [TestMethod]
        [DataRow(100, 212)]
        [DataRow(0, 32)]
        [DataRow(-40, -40)]
        [DataRow(37, 98.60)]
        public void test_Farenheit_fromCelsiustoSelf(double temp, double expected) {
            Assert.AreEqual(expected, Math.Round(_farenheitConverter.fromCelsiustoSelf(temp),2));
            
        }

    }
}

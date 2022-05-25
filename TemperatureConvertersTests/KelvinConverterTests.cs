using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;
using System;


namespace TemperatureConvertersTests
{
    [TestClass]
    public class KelvinConverterTests
    {

        
        KelvinConverter _kelvinConverter = new KelvinConverter();

        [TestMethod]
        [DataRow(100, 100)]
        [DataRow(92.70, 92.7)]
        [DataRow(-100, -100)]
        public void test_Farenheit_fromKelvintoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_kelvinConverter.fromKelvintoSelf(temp), 2));

        }

        [TestMethod]
        [DataRow(180, 453.00)]
        [DataRow(212, 485.00)]
        [DataRow(-180, 155.37)]
        [DataRow(-212, 137.59)]
        [DataRow(-40, 233.15)]
        public void test_Kelvin_fromFarenheittoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_kelvinConverter.fromFarenheittoSelf(temp), 2));

        }



        [TestMethod]
        [DataRow(100, 373)]
        [DataRow(-100, 173)]
        [DataRow(0, 273)]
        [DataRow(30, 303)]
        public void test_Kelvin_fromCelsiustoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_kelvinConverter.fromCelsiustoSelf(temp), 2));

        }

    }
}

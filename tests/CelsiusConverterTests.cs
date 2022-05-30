using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;
using System;

namespace TemperatureConvertersTests
{
    [TestClass]
    public class CelsiusConverterTests
    {

        CelsiusConverter _celsiusConverter = new CelsiusConverter();

      
        [TestMethod]
        [DataRow(100, 100)]
        [DataRow(92.70, 92.7)]
        [DataRow(-92.78, -92.78)]
        [DataRow(-100, -100)]
        public void test_Celsius_fromCelsiustoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_celsiusConverter.fromCelsiustoSelf(temp), 2));

        }

        [TestMethod]
        [DataRow(-40, -40)]
        [DataRow(98.6, 37)]
        [DataRow(32, 0)]
        [DataRow(212, 100)]
        public void test_Celsius_fromFarenheittoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_celsiusConverter.fromFarenheittoSelf(temp), 2));

        }
    

        [TestMethod]
        [DataRow(373, 100)]
        [DataRow(173, -100)]
        [DataRow(273, 0)]
        [DataRow(303, 30)]
        public void test_Celsius_fromKelvintoSelf(double temp, double expected)
        {
            Assert.AreEqual(expected, Math.Round(_celsiusConverter.fromKelvintoSelf(temp), 2));

        }
    }
}

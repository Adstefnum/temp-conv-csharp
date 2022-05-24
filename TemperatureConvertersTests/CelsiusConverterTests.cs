using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
    public class CelsiusConverterTests
    {

        CelsiusConverter _celsiusConverter = new CelsiusConverter();

        [TestMethod]
        public void test_Celsius_fromCelsiustoSelf()
        {
            Assert.AreEqual(100, _celsiusConverter.fromCelsiustoSelf(100));
            Assert.AreEqual(-100, _celsiusConverter.fromCelsiustoSelf(-100));
            Assert.AreEqual(92.7, _celsiusConverter.fromCelsiustoSelf(92.7f));

            //failing
            Assert.AreEqual(-92.78, _celsiusConverter.fromCelsiustoSelf(-92.78f));
            

        }

        [TestMethod]
        public void test_Celsius_fromFarenheittoSelf()
        {

            Assert.AreEqual(-40, _celsiusConverter.fromFarenheittoSelf(-40));
            Assert.AreEqual(37, _celsiusConverter.fromFarenheittoSelf(98.6f));
            Assert.AreEqual(0, _celsiusConverter.fromFarenheittoSelf(32));

        }

        [TestMethod]
        public void test_Celsius_fromKelvintoSelf()
        {

            Assert.AreEqual(30, _celsiusConverter.fromKelvintoSelf(303));

        }
    }
}

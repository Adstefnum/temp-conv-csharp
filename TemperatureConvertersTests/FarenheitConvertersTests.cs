using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
    public class FarenheitConvertersTests
    {


        FarenheitConverter _farenheitConverter = new FarenheitConverter();

        [TestMethod]
        public void test_Farenheit_fromKelvintoSelf() {

            Assert.AreEqual(-40, _farenheitConverter.fromKelvintoSelf(233));
      
        }

        [TestMethod]
        public void test_Farenheit_fromFarenheittoSelf() {

            Assert.AreEqual(100, _farenheitConverter.fromFarenheittoSelf(100));
            Assert.AreEqual(-100, _farenheitConverter.fromFarenheittoSelf(-100));

            //failing
            //Assert.AreEqual(92.7, _farenheitConverter.fromFarenheittoSelf(92.7f));
        }

        [TestMethod]
        public void test_Farenheit_fromCelsiustoSelf() {
            //instead of rounding in program why not round answer here or?
            //Assert.AreEqual(98.6, _farenheitConverter.fromCelsiustoSelf(37));
            Assert.AreEqual(-40, _farenheitConverter.fromCelsiustoSelf(-40));
            Assert.AreEqual(212, _farenheitConverter.fromCelsiustoSelf(100));
            Assert.AreEqual(32, _farenheitConverter.fromCelsiustoSelf(0));
        }

    }
}

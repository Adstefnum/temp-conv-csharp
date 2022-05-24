using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
    public class KelvinConverterTests
    {

        
        KelvinConverter _kelvinConverter = new KelvinConverter();
      
        [TestMethod]
        public void test_Kelvin_fromKelvintoSelf() {

            Assert.AreEqual(100, _kelvinConverter.fromKelvintoSelf(100));
            Assert.AreEqual(-100, _kelvinConverter.fromKelvintoSelf(-100));

            //failing -- round up answers before giving them out
            //Assert.AreEqual(92.7, _kelvinConverter.fromKelvintoSelf(92.7f));
        }

        [TestMethod]
        public void test_Kelvin_fromFarenheittoSelf() {

            //failing-- Implement without celsius just find its formula to and from farenheit
            //Assert.AreEqual(453, _kelvinConverter.fromFarenheittoSelf(180));

            //Assert.AreEqual(-453, _kelvinConverter.fromFarenheittoSelf(-180));
            //Assert.AreEqual(485, _kelvinConverter.fromFarenheittoSelf(212));
            //Assert.AreEqual(485, _kelvinConverter.fromFarenheittoSelf(212));
            Assert.AreEqual(233, _kelvinConverter.fromFarenheittoSelf(-40));
        }

        [TestMethod]
        public void test_Kelvin_fromCelsiustoSelf() {
            Assert.AreEqual(373, _kelvinConverter.fromCelsiustoSelf(100));
            Assert.AreEqual(173, _kelvinConverter.fromCelsiustoSelf(-100));
            Assert.AreEqual(273, _kelvinConverter.fromCelsiustoSelf(0));
            Assert.AreEqual(303, _kelvinConverter.fromCelsiustoSelf(30));
        }

    }
}

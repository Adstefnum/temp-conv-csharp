using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
    public class KelvinConverterTests
    {

        
        KelvinConverter _kelvinConverter = new KelvinConverter();
      
        [TestMethod]
        public void test_Kelvin_fromKelvintoSelf() { }

        [TestMethod]
        public void test_Kelvin_fromFarenheittoSelf() { }

        [TestMethod]
        public void test_Kelvin_fromCelsiustoSelf() { }

    }
}

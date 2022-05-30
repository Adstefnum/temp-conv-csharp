using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
   public class FarenheitToCelsiusTests
    {
        [DataRow(-40,-40)]
        [DataRow(32,0)]
        [DataRow(98.6, 37)]
        [DataRow(212,100)]
        [TestMethod]
    public void test_FarenheitToCelsius(double Temp, double expected){
       ITemperatureConverter converter = new FarenheitToCelsius(); 
       double result  = System.Math.Round(converter.ConvertToTemperatureScale(Temp),2);
       Assert.AreEqual(expected, result);
        }
    }
}

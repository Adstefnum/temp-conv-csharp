using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
   public class CelsiusToFarenheitTests
    {
        [DataRow(-40,-40)]
        [DataRow(0,32)]
        [DataRow(37, 98.6)]
        [DataRow(100,212)]
        [TestMethod]
    public void test_CelsiusToFarenheit(double Temp, double expected){
       ITemperatureConverter converter = new CelsiusToFarenheit(); 
       double result  = System.Math.Round(converter.ConvertToTemperatureScale(Temp),2);
       Assert.AreEqual(expected, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
   public class CelsiusToKelvinTests
    {
        [DataRow(100, 373)]
        [DataRow(-100, 173)]
        [DataRow(0, 273)]
        [DataRow(30, 303)]
        [TestMethod]
    public void test_CelsiusToKelvin(double Temp, double expected){
       ITemperatureConverter converter = new CelsiusToKelvin(); 
       double result  = System.Math.Round(converter.ConvertToTemperatureScale(Temp),2);
       Assert.AreEqual(expected, result);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
   public class KelvinToCelsiusTests
    {
        [DataRow(373,100)]
        [DataRow(173, -100)]
        [DataRow(273, 0)]
        [DataRow(303, 30)]
        [TestMethod]
    public void test_KelvinToCelsius(double Temp, double expected){
       ITemperatureConverter converter = new KelvinToCelsius(); 

       double result  = System.Math.Round(converter.ConvertToTemperatureScale(Temp),2);

       Assert.AreEqual(expected, result);
        }
    }
}

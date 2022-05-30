using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
   public class KelvinToFarenheitTests
    {
        [DataRow(0,-459.67)]
        [DataRow(-100,-639.67)]
        [DataRow(-105.678, -649.89)]
        [DataRow(230,-45.67)]
        [DataRow(280,44.33)]
        [DataRow(1000,1340.33)]
        [TestMethod]
    public void test_KelvinToFarenheit(double Temp, double expected){
       ITemperatureConverter converter = new KelvinToFarenheit(); 
       double result  = System.Math.Round(converter.ConvertToTemperatureScale(Temp),2);
       Assert.AreEqual(expected, result);
        }
    }
}

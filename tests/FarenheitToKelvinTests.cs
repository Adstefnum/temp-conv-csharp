using Microsoft.VisualStudio.TestTools.UnitTesting;
using Temperature_Converters;

namespace TemperatureConvertersTests
{
    [TestClass]
   public class FarenheitToKelvinTests
    {
        [DataRow(-459.67,0)]
        [DataRow(-639.67,-100)]
        [DataRow(-649.89,-105.68)]
        [DataRow(-45.67,230)]
        [DataRow(44.33,280)]
        [DataRow(1340.33,1000)]
        [TestMethod]
    public void test_FarenheitToKelvin(double Temp, double expected){
       ITemperatureConverter converter = new FarenheitToKelvin(); 
       double result  = System.Math.Round(converter.ConvertToTemperatureScale(Temp),2);
       Assert.AreEqual(expected, result);
        }
    }
}

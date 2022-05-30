using System;

namespace Temperature_Converters{

   public class FarenheitToCelsius: ITemperatureConverter{

       public double ConvertToTemperatureScale(double Temp){
           return (Temp * 9 / 5) + 32;        
 }

}}


using System;

namespace Temperature_Converters{

   public class FarenheitToCelsius: ITemperatureConverter{

       public double ConvertToTemperatureScale(double Temp){
           return (Temp -32) * 5/9;        
 }

}}


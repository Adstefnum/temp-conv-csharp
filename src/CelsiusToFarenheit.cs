using System;

namespace Temperature_Converters{

   public class CelsiusToFarenheit: ITemperatureConverter{

       public double ConvertToTemperatureScale(double Temp){
           return (Temp * 9 / 5) + 32;  
       }

}}

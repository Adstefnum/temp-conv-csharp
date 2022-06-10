using System;

namespace Temperature_Converters{

   public class CelsiusToKelvin: ITemperatureConverter{

      public double ConvertToTemperatureScale(double InputTemperature){
           return InputTemperature + 273;
       }
   }
}

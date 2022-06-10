using System;

namespace Temperature_Converters{

   public class CelsiusToFarenheit: ITemperatureConverter{

       public double ConvertToTemperatureScale(double InputTemperature){
           return (InputTemperature * 9 / 5) + 32;  
       }

    }
}

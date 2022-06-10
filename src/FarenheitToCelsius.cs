using System;

namespace Temperature_Converters{

   public class FarenheitToCelsius: ITemperatureConverter{

       public double ConvertToTemperatureScale(double InputTemperature){
           return (InputTemperature -32) * 5/9;        
     }

    }
}


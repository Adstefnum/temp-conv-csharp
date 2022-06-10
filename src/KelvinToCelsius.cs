using System;

namespace Temperature_Converters{

   public class KelvinToCelsius: ITemperatureConverter{

       public double ConvertToTemperatureScale(double InputTemperature){
           return InputTemperature - 273;
       }

    }
}

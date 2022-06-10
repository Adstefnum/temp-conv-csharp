using System;

namespace Temperature_Converters{

   public class KelvinToFarenheit: ITemperatureConverter{

       public double ConvertToTemperatureScale(double InputTemperature){
        
           InputTemperature = (InputTemperature * 9 / 5) - 459.67;
            return InputTemperature;
        }

    }
}

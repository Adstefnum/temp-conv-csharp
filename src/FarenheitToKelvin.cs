using System;

namespace Temperature_Converters{

   public class FarenheitToKelvin: ITemperatureConverter{

       public double ConvertToTemperatureScale(double InputTemperature){
            InputTemperature = (InputTemperature + 459.67) * 5/9;
            return InputTemperature;
       
        }

    }
}

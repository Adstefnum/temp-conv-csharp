using System;

namespace Temperature_Converters{

   public class KelvinToFarenheit: ITemperatureConverter{

       public double ConvertToTemperatureScale(double Temp){
        
           Temp = (Temp * 9 / 5) - 459.67;
            return Temp;
 }

}}

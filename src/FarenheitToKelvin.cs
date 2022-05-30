using System;

namespace Temperature_Converters{

   public class FarenheitToKelvin: ITemperatureConverter{

       public double ConvertToTemperatureScale(double Temp){
            Temp = (Temp + 459.67) * 5/9;
            return Temp;
       
 }

}}

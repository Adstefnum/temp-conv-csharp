using System;

namespace Temperature_Converters{

   public class KelvinToCelsius: ITemperatureConverter{

       public double ConvertToTemperatureScale(double Temp){
           return Temp - 273;
       }

}}

using System;

namespace Temperature_Converters{

   public class CelsiusToKelvin: ITemperatureConverter{

      public double ConvertToTemperatureScale(double Temp){
           return Temp + 273;
       }

}}

using System;

namespace Temperature_Converters
{
    public interface ITemperatureConverter
    {
       double ConvertToTemperatureScale(double Temp);
}}

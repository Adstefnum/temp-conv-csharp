using System;

namespace Temperature_Converters{

     class TemperatureConverterFactory{
        
         public ITemperatureConverter ChooseConverter(char CurrentUnit, char ToUnit){
             
                var ConverterClasses = new System.Collections.Generic.Dictionary<string, Type>();
            
                ConverterClasses.Add("KC",typeof(KelvinToCelsius));
                ConverterClasses.Add("CK",typeof(CelsiusToKelvin));
                ConverterClasses.Add("FC",typeof(FarenheitToCelsius));
                ConverterClasses.Add("CF",typeof(CelsiusToFarenheit));
                ConverterClasses.Add("FK",typeof(FarenheitToKelvin));
                ConverterClasses.Add("KF",typeof(KelvinToFarenheit));
                
                string ClassIndex = $"{CurrentUnit}{ToUnit}";
                return (ITemperatureConverter)Activator.CreateInstance(ConverterClasses[ClassIndex]);
         }
    }}

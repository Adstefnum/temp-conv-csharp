﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    public class CelsiusConverter : ITemperatureConverters
    {

        public object classMain(char fromMode, float Temp)
        {
            
            var converterFunctions = new System.Collections.Generic.Dictionary<char, Delegate>();
            converterFunctions['K'] = new Func<float, float>(fromKelvintoSelf);
            converterFunctions['F'] = new Func<float, float>(fromFarenheittoSelf);
            converterFunctions['C'] = new Func<float, float>(fromCelsiustoSelf);


            return converterFunctions[fromMode].DynamicInvoke(Temp);
        }
        public  float fromKelvintoSelf(float Temp) {

            return Temp-273;
        }

        public  float fromFarenheittoSelf(float Temp)
        {
           
            return ((Temp - 32) * 5 / 9); 
        }

        public  float fromCelsiustoSelf(float Temp)
        {

            return Temp;
        }
    }
}
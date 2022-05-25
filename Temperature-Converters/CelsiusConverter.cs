using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    public class CelsiusConverter : ITemperatureConverters
    {

        public object classMain(char fromMode, double Temp)
        {
            
            var converterFunctions = new System.Collections.Generic.Dictionary<char, Delegate>();
            converterFunctions['K'] = new Func<double, double>(fromKelvintoSelf);
            converterFunctions['F'] = new Func<double, double>(fromFarenheittoSelf);
            converterFunctions['C'] = new Func<double, double>(fromCelsiustoSelf);


            return converterFunctions[fromMode].DynamicInvoke(Temp);
        }
        public  double fromKelvintoSelf(double Temp) {

            return Temp-273;
        }

        public  double fromFarenheittoSelf(double Temp)
        {
           
            return ((Temp - 32) * 5 / 9); 
        }

        public  double fromCelsiustoSelf(double Temp)
        {

            return Temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    public class FarenheitConverter: ITemperatureConverters
    {

        public object classMain(char fromMode, double Temp)
        {

            var converterFunctions = new System.Collections.Generic.Dictionary<char, Delegate>();
            converterFunctions['K'] = new Func<double, double>(fromKelvintoSelf);
            converterFunctions['F'] = new Func<double, double>(fromFarenheittoSelf);
            converterFunctions['C'] = new Func<double, double>(fromCelsiustoSelf);


            return converterFunctions[fromMode].DynamicInvoke(Temp);
        }
        public double fromKelvintoSelf(double Temp)
        {
            Temp = (Temp * 9 / 5) - 459.67;
            return Temp;
        }

        public double fromFarenheittoSelf(double Temp)
        {

            return Temp;
        }

        public double fromCelsiustoSelf(double Temp)
        {

            return (Temp * 9 / 5) + 32; 
        }
    }
}

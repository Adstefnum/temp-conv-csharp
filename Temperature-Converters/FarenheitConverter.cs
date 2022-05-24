using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    public class FarenheitConverter: ITemperatureConverters
    {

        public object classMain(char fromMode, float Temp)
        {

            var converterFunctions = new System.Collections.Generic.Dictionary<char, Delegate>();
            converterFunctions['K'] = new Func<float, float>(fromKelvintoSelf);
            converterFunctions['F'] = new Func<float, float>(fromFarenheittoSelf);
            converterFunctions['C'] = new Func<float, float>(fromCelsiustoSelf);


            return converterFunctions[fromMode].DynamicInvoke(Temp);
        }
        public float fromKelvintoSelf(float Temp)
        {
            CelsiusConverter _celsiusConverter = new CelsiusConverter();
            Temp = Temp - 273;
            return _celsiusConverter.fromFarenheittoSelf(Temp);
        }

        public float fromFarenheittoSelf(float Temp)
        {

            return Temp;
        }

        public float fromCelsiustoSelf(float Temp)
        {

            return (Temp * 9 / 5) + 32; 
        }
    }
}

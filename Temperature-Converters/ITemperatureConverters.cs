using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    interface ITemperatureConverters
    {
        object classMain(char fromMode, float Temp);
         float fromKelvintoSelf(float Temp);
        float fromFarenheittoSelf(float Temp);
        float fromCelsiustoSelf(float Temp);
    }
}

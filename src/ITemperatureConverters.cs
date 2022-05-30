using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    interface ITemperatureConverters
    {
        object classMain(char fromMode, double Temp);
         double fromKelvintoSelf(double Temp);
        double fromFarenheittoSelf(double Temp);
        double fromCelsiustoSelf(double Temp);
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            float temp = 0f;
            char fromMode = '0';
            double result;
            var converterClasses = new System.Collections.Generic.Dictionary<char, Delegate>();
            CelsiusConverter _celsiusConverter = new CelsiusConverter();
            FarenheitConverter _farenheitConverter = new FarenheitConverter();
            KelvinConverter _kelvinConverter = new KelvinConverter();
            converterClasses['C'] = new Func<char,float,object>(_celsiusConverter.classMain);
            converterClasses['F'] = new Func<char, float, object>(_farenheitConverter.classMain);
            converterClasses['K'] = new Func<char, float, object>(_kelvinConverter.classMain);


            //TODO parsing for the char modes like temp and if wrong ask them to put right value
            //TODO checking if it is in list of chars for temp scale and tell them it si currently not supported


            Console.WriteLine(@"Please Enter the unit of temperature you are converting from\n
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
             fromMode = Char.ToUpper(Console.ReadLine()[0]);

            Console.WriteLine(@"Please Enter the unit of temperature you are converting to\n
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
            char toMode = Char.ToUpper(Console.ReadLine()[0]);


           

            do
            {
                Console.WriteLine("Please enter the temperature value:");
            }
            while (!float.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out temp));

                result = Convert.ToDouble(converterClasses[toMode].DynamicInvoke(fromMode, temp));

            
            Console.WriteLine($"{temp} {fromMode} = {Math.Round(result,2)} {toMode}");
            Console.ReadLine();
        }
    }
}

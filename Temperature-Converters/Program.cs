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
            //seeting up correct cultural context for program
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            //setting up state variables and structres
            double temp = 0f;
            char fromMode = '0';
            char toMode = '0';
            double result;
            List<Char> scales = new List<Char>() { 'F','C','K'};
            var converterClasses = new System.Collections.Generic.Dictionary<char, Delegate>();
            CelsiusConverter _celsiusConverter = new CelsiusConverter();
            FarenheitConverter _farenheitConverter = new FarenheitConverter();
            KelvinConverter _kelvinConverter = new KelvinConverter();
            converterClasses['C'] = new Func<char,double,object>(_celsiusConverter.classMain);
            converterClasses['F'] = new Func<char, double, object>(_farenheitConverter.classMain);
            converterClasses['K'] = new Func<char, double, object>(_kelvinConverter.classMain);


            //parsing for right input
            //I also need to check for special chars
            do {
                Console.WriteLine(@"Please Enter the unit of temperature you are converting from\n
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
                fromMode = Char.ToUpper(Console.ReadLine()[0]);
            }
            while (!scales.Contains(fromMode));

            do
            {
                Console.WriteLine(@"Please Enter the unit of temperature you are converting to\n
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
                toMode = Char.ToUpper(Console.ReadLine()[0]);
            }
            while (!scales.Contains(fromMode));



            do
            {
                Console.WriteLine("Please enter the temperature value:");
            }
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out temp));

            //getting results from appropriate classes
           result = Convert.ToDouble(converterClasses[toMode].DynamicInvoke(fromMode, temp));

            
            Console.WriteLine($"{temp} {fromMode} = {Math.Round(result,2)} {toMode}");
            Console.ReadLine();


            
        }
    }
}

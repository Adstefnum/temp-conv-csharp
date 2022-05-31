using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Temperature_Converters
{
    class Program
    {

        static void Main(string[] args)
        {
            //setting up correct cultural context for program
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            
           //collecting values from user 
            char CurrentUnit = CollectTemperatureUnit("from");
            char ToUnit = CollectTemperatureUnit("to");
            double Temp = CollectTemperatureValue();
            
            //converting the temperature
            TemperatureConverterFactory Factory = new TemperatureConverterFactory();
            ITemperatureConverter converter = Factory.ChooseConverter(CurrentUnit, ToUnit);
            double Result =  converter.ConvertToTemperatureScale(Temp);
            
            Console.WriteLine($"{Temp} {CurrentUnit} = {Math.Round(Result,2)} {ToUnit}");
            Console.ReadLine();
            
        }

       public static char CollectTemperatureUnit(string mode){

            string Input;char Unit;
            List<Char> scales = new List<Char>() { 'F','C','K'};
            var regex = new Regex(@"[^a-zA-Z0-9\s]");
            do {
                Console.WriteLine($@"Please Enter the unit of temperature you are converting {mode}
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
                Input = Console.ReadLine();
                Unit = !String.IsNullOrEmpty(Input) ? Char.ToUpper(Input[0]): '\0';
                Unit = regex.IsMatch(Unit.ToString())? '\0':Unit;

                if(!scales.Contains(Unit)){
                    Console.WriteLine("You must choose from the options in the list");
                    Console.WriteLine();
                }
            }
            while (!scales.Contains(Unit));

            return Unit;
        }

        static double CollectTemperatureValue(){

            double Temp = 0.0;
            do
            {
                Console.WriteLine("Please enter the temperature value:");
            }
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out Temp));

            return Temp;
        }
    }

}


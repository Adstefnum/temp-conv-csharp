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

        static List<Char> scales = new List<Char>() { 'F','C','K'};
        static void Main(string[] args)
        {
            //setting up correct cultural context for program
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            
           //collecting values from user 
            char CurrentUnit = CollectCurrentTemperatureUnit();
            char ToUnit = CollectDestinationTemperatureUnit();
            double Temp = CollectTemperatureValue();
            
            //converting the temperature
            TemperatureConverterFactory Factory = new TemperatureConverterFactory();
            ITemperatureConverter converter = Factory.ChooseConverter(CurrentUnit, ToUnit);
            double Result =  converter.ConvertToTemperatureScale(Temp);
            
            Console.WriteLine($"{Temp} {CurrentUnit} = {Math.Round(Result,2)} {ToUnit}");
            Console.ReadLine();
            
        }

       public static char CollectCurrentTemperatureUnit(){

            char CurrentUnit = '0';
            do {
                Console.WriteLine(@"Please Enter the unit of temperature you are converting from\n
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
                CurrentUnit = Char.ToUpper(Console.ReadLine()[0]);
            }
            while (!scales.Contains(CurrentUnit));

            return CurrentUnit;
        }


        public static char CollectDestinationTemperatureUnit(){

            char ToUnit = '0';
            do {
                Console.WriteLine(@"Please Enter the unit of temperature you are converting to\n
                     C - Celsius / Centigrade\n
                     F - Farenheit\n
                     K - Kelvin:");
                ToUnit = Char.ToUpper(Console.ReadLine()[0]);
            }
            while (!scales.Contains(ToUnit));

            return ToUnit;
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


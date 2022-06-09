using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
           InputCollector Client = new InputCollector();
            char CurrentUnit = Client.CollectTemperatureUnit("from");
            char ToUnit = Client.CollectTemperatureUnit("to");
            double Temp = Client.CollectTemperatureValue();
            
            //converting the temperature
            TemperatureConverterFactory Factory = new TemperatureConverterFactory();
            ITemperatureConverter converter = Factory.ChooseConverter(CurrentUnit, ToUnit);
            double Result =  converter.ConvertToTemperatureScale(Temp);
            
            Console.WriteLine($"{Temp} {CurrentUnit} = {Math.Round(Result,2)} {ToUnit}");
            
        }


}}

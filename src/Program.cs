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
           InputCollector UserInputCollector = new InputCollector();
            char InputUnit = UserInputCollector.CollectTemperatureUnit("from");
            char ToUnit = UserInputCollector.CollectTemperatureUnit("to");
            double InputTemperature = UserInputCollector.CollectTemperatureValue();
            
            //converting the temperature
            TemperatureConverterFactory Factory = new TemperatureConverterFactory();
            ITemperatureConverter converter = Factory.ChooseConverter(InputUnit, ToUnit);
            double ConvertedTemperature =  converter.ConvertToTemperatureScale(InputTemperature);
            
            ResultPrinter printer = new ResultPrinter();
            printer.InputUnit = InputUnit;
            printer.ToUnit = ToUnit;
            printer.InputTemperature = InputTemperature;
            printer.ConvertedTemperature = ConvertedTemperature;
            printer.PrintPlainTextResultToConsole();
            
        }


}}

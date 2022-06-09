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
            char CurrentUnit = UserInputCollector.CollectTemperatureUnit("from");
            char ToUnit = UserInputCollector.CollectTemperatureUnit("to");
            double Temp = UserInputCollector.CollectTemperatureValue();
            
            //converting the temperature
            TemperatureConverterFactory Factory = new TemperatureConverterFactory();
            ITemperatureConverter converter = Factory.ChooseConverter(CurrentUnit, ToUnit);
            double Result =  converter.ConvertToTemperatureScale(Temp);
            
            ResultPrinter printer = new ResultPrinter();
            string ResultText = $"{Temp} {CurrentUnit} = {Math.Round(Result,2)} {ToUnit}";
            printer.PrintPlainTextResultToConsole(ResultText);
            
        }


}}

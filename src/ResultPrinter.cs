using System;
using System.Text;

namespace Temperature_Converters
{
    public class ResultPrinter: IResultPrinter{
        public char InputUnit;
        public char ToUnit;
        public double  InputTemperature;
        public double ConvertedTemperature;
        public void PrintPlainTextResultToConsole(){
            Console.WriteLine($"{InputTemperature} {InputUnit} = {Math.Round(ConvertedTemperature,2)} {ToUnit}");
        }
    }
}

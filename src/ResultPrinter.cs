using System;
using System.Text;

namespace Temperature_Converters
{
    public class ResultPrinter: IResultPrinter{
        public void PrintPlainTextResultToConsole(string ResultText){
            Console.WriteLine(ResultText);
        }
    }
}

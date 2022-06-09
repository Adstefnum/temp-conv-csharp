using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Temperature_Converters
{
    public class InputCollector: IInputCollector
    {
        public char CollectTemperatureUnit(string mode){

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

       public double CollectTemperatureValue(){

            double Temp = 0.0;
            do
            {
                Console.WriteLine("Please enter the temperature value:");
            }
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture, out Temp));

            return Temp;
        }
    }}

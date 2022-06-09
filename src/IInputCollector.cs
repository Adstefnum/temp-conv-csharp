
namespace Temperature_Converters
{
    public interface IInputCollector
    {
        char CollectTemperatureUnit(string mode);
        double CollectTemperatureValue();
    }
}

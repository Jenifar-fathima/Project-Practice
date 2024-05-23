namespace Project_ExercisesLogic;

public static class TemperatureConverter
{
    public static string ConvertorMethod(int nInputTemperature, string strUnit)
    {
        int nConvertedTemperature;
        string strConvertedUnit;
        switch (strUnit)
        {
            case "C":
                nConvertedTemperature = (nInputTemperature - 32) * 5 / 9;
                strConvertedUnit = "Celsius";
                break;

            case "F":
                nConvertedTemperature = (nInputTemperature * 9 / 5) + 32;
                strConvertedUnit = "Fahrenheit";
                break;

            default:
                return $"Invalid Unit! Please enter the correct unit";
        }
        return $"The temperature in {strConvertedUnit} is {nConvertedTemperature}.";
    }
}

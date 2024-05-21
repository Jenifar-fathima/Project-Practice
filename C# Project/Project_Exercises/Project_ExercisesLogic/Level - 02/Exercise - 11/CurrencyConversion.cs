namespace Project_ExercisesLogic;

public static class CurrencyConversion
{
    public static string ConversionMethod(double nEuroAmount,double nEuroRate)
    {
        double nDollerAmount = (nEuroAmount * nEuroRate) / 100;

        return $"{nEuroAmount} euros at an exchange rate of {nEuroRate:F2} is {nDollerAmount:F2} U.S. dollars.";
    }
}


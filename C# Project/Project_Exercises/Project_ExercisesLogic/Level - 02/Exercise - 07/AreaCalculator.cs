namespace Project_ExercisesLogic;
public static class TaxCalculator
{
    public static string CalulatorMethod(int nLength,int nWidth)
    {
        double nArea = nLength * nWidth;
        double nFeetToSquareMeter = nArea * 0.09290304;

        return $"You entered dimensions of {nLength} feet by {nWidth} feet.\r\nThe area is\r\n{nArea} square feet\r\n{nFeetToSquareMeter:F3} square meters";

    }
}


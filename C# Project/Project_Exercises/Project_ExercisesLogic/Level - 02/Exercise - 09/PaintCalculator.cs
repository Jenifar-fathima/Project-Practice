namespace Project_ExercisesLogic;
public static class PaintCalculator
{
    public static string CalculatorMethod(int nLength, int nWidth)
    {
        int nArea = nLength * nWidth;
        float nGalloon = nArea / 350;

        if(nArea % 350 >= 0)
        {
            nGalloon += 1;
        }
        return $"You will need to purchase {nGalloon} gallons of paint to cover {nArea} square feet.";
    }
}

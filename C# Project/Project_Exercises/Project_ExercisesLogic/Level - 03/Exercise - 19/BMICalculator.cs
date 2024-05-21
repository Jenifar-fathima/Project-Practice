namespace Project_ExercisesLogic;

public static class BMICalculator
{
    public static string CalculatonMethod(double nHeight,double nWeight)
    {
        double nBMI = (nWeight / (nHeight * nHeight)) * 703;
        string strBodyLevel = nBMI < 18.5 ? "underweight" : "overweight";
        if (nBMI > 18.5 && nBMI <25)
        {
            return $"You are within the ideal weight range.";
        } 
        else 
        {
            return $"You are {strBodyLevel}. You should see your doctor.";
        }
    }
}

namespace Project_ExercisesLogic;
public static class TaxCalculation
{
    public static string CalulatorMethod(int nAmount, string strState)
    {
        string result = strState == "WI"
    ? $"The subtotal is ${nAmount:F2}.\nThe tax is ${(nAmount * 0.055):F2}.\nThe total is ${(nAmount * 1.055):F2}."
    : strState == "MN"
    ? $"The total is ${nAmount:F2}."
    : "Invalid State";

        return result;

    }
}


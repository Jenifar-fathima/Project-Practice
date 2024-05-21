namespace Project_ExercisesLogic;

public static class SimpleInterest
{
    public static string SimpleInterestCalculator(double nPrincipal,double nRate,double nTime)
    {
        double nInterest = (nPrincipal *  nRate * nTime)/100;
        double nAmount = nInterest + nPrincipal;

        return $"After {nTime} years at {nRate} %, the investment will be worth ${nAmount}.";
    }
}

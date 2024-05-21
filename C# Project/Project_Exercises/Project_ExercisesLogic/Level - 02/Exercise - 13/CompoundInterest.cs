using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project_ExercisesLogic;

public static class CompoundInterest
{
    public static string InterestCalculationMethod(double nPrincipal, double nRate, int nTime, int nCount)
    {
        double nRatePerPeriod = nRate / nCount;
        int nTotalPeriods = nCount * nTime;

        double nFutureValue = nPrincipal * Math.Pow(1 + nRatePerPeriod, nTotalPeriods);

        return $"${nPrincipal} invested at {nRate * 100}% for {nTime} years compounded {nCount} times per year is ${nFutureValue:F2}.";
    }
}

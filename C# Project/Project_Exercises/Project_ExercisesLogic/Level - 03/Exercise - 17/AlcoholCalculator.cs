namespace Project_ExercisesLogic;
public static class AlcoholCalculator
{
    public static string CalculateBAC(double nWeight, string strGender, int nDrinksCount, double nVolumePerDrink, double nHoursSinceLastDrink)
    {
        
        const double AlcoholDistributionRatioMale = 0.73;
        const double AlcoholDistributionRatioFemale = 0.66;
        const double StandardDrinkAlcoholContent = 0.6; 

        double nRate = (strGender == "male") ? AlcoholDistributionRatioMale : AlcoholDistributionRatioFemale;

        double totalAlcohol = nDrinksCount * nVolumePerDrink * StandardDrinkAlcoholContent;
 
        double nBAC = ((totalAlcohol * 5.14 / (nWeight * nRate)) - 0.015 * nHoursSinceLastDrink) / 10;

        if(nBAC < 0.08)
        {
            return $"It is legal for you to drive.";
        }
        else
        {
            return $"It is not legal for you to drive.";
        }
    }
}

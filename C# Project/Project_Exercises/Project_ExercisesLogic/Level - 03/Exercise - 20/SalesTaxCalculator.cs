namespace Project_ExercisesLogic
{
    public static class SalesTaxCalculator
    {
        public static string CalculationMethod(string strState, string strCounty, double nAmount)
        {
            double nFinalTax = 0;
            const double nClaireTax = 0.005;
            const double nDunnTax = 0.004;

            if (strState == "Wisconsin")
            {
                if (strCounty == "Eau Claire")
                {
                    nFinalTax = 100 * nClaireTax;
                }
                else if (strCounty == "Dunn")
                {
                    nFinalTax = 100 * nDunnTax;
                }
                else
                {
                    return "Enter Valid Country name";
                }
            }
            else if (strState == "Illinois")
            {
                nFinalTax = nAmount * 0.08; 
            }

            double nFinalAmount = nAmount + nFinalTax;
            if (nFinalTax > 0)
            {
                return $"The tax is ${nFinalTax:F2}. The total is ${nFinalAmount:F2}.";
            }
            else
            {
                return $"The total is ${nAmount:F2}";
            }
        }
    }
}

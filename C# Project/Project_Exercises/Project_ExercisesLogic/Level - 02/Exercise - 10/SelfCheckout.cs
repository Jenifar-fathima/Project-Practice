namespace Project_ExercisesLogic;

public static class SelfCheckout
{
    public static string CalculationMethod(int[] lstPrice, int[] lstQuantity)
    {
        double nSubTotal = 0;
        double nTax = 0;
        double nTotal = 0;
        if(lstPrice.Length == lstQuantity.Length)
        {
            for(int i = 0;i < lstPrice.Length;i++)
            {
                nSubTotal += lstPrice[i] * lstQuantity[i];
            }
            nTax = nSubTotal * 5.5 / 100;
            nTotal = nTax + nSubTotal;
        }
        return $"Subtotal: ${nSubTotal:F2}\nTax: ${nTax:F2}\nTotal: ${nTotal:F2}";
    }
}
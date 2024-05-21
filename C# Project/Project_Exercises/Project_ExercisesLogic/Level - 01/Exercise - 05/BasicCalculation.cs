namespace Project_ExercisesLogic
{
    public static class BasicCalculation
    {
        public static string CalculationMethod(int nNumber1, int nNumber2) 
        {
            return $"[\n\t\"{nNumber1} + {nNumber2} = {nNumber1 + nNumber2}\",\n\t\"{nNumber1} - {nNumber2} = {nNumber1 - nNumber2}\",\n\t\"{nNumber1} * {nNumber2} = {nNumber1 * nNumber2}\",\n\t\"{nNumber1} / {nNumber2} = {nNumber1 / nNumber2}\",\n\t\"{nNumber1} % {nNumber2} = {nNumber1 % nNumber2}\"\n]";
        }
    }
}

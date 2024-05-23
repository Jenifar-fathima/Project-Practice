namespace Project_ExercisesLogic
{
    public static class RetirementAgeCalculator
    {
        public static string AgeCalculatorMethod(int nCurrentAge, int nRetirementAge)
        {
            int nBalanceYear = nRetirementAge - nCurrentAge;
            int nRetirementYear = 2024 + nBalanceYear;

            return $"You have {nBalanceYear} years left before you can retire.\r\nIt's 2024, so you can retire in {nRetirementYear}.";
        }
    }
}

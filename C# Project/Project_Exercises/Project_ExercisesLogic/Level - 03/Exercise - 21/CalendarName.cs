namespace Project_ExercisesLogic
{
    public static class CalendarName
    {
        public static string SampleMethod(int nMonthNumber)
        {
            string[] lstMonth = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            if (nMonthNumber >= 1 && nMonthNumber <= 12)
            {
                return $"The name of the month is {lstMonth[nMonthNumber - 1]}.";
            }
            else
            {
                return "Enter a number between 1 to 12.";
            }
        }
    }
}

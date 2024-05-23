namespace Project_ExercisesLogic
{
    public static class LegalDrivingAge
    {
        public static string AgeMethod(string userInput)
        {
            int nAge;
            if (int.TryParse(userInput, out nAge))
            {
                if (nAge >= 16)
                {
                    return $"You are old enough to legally drive.";
                }
                else
                {
                    return $"You are not old enough to legally drive.";
                }
            }
            else
            {
                return $"Invalid input. Please enter a valid age.";
            }
        }
    }
}

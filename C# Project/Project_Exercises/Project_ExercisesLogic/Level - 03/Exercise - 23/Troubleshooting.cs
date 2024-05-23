namespace Project_ExercisesLogic
{
    public static class TroubleShooting
    {
        public static string TroubleshootIssue(bool isSilent, bool corrodedTerminals, bool clickingNoise, bool crankNoStart, bool engineStartDie, bool hasFuelInjection)
        {
            if (isSilent)
            {
                if (corrodedTerminals)
                {
                    return "Clean terminals and try starting again.";
                }
                else
                {
                    return "Replace cables and try again.";
                }
            }
            else if (clickingNoise)
            {
                return "Replace the battery.";
            }
            else if (crankNoStart)
            {
                return "Check spark plug connections.";
            }
            else if (engineStartDie)
            {
                if (hasFuelInjection)
                {
                    return "Get it in for service.";
                }
                else
                {
                    return "Check to ensure the choke is opening and closing.";
                }
            }
            else
            {
                return "Unknown issue.";
            }
        }
    }
}

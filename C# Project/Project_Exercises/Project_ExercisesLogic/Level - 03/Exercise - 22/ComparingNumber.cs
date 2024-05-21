namespace Project_ExercisesLogic;

public static class ComparingNumber
{
    public static string ComparingMethod(int[] lstArray)
    {
        if (lstArray == null || lstArray.Length == 0)
        {
            return "Array is empty or null";
        }

        int max = lstArray[0];
        for (int i = 0; i < lstArray.Length; i++)
        { 
                if (max < lstArray[i])
                {
                    max = lstArray[i];
                }
        }
        return $"The largest number is {max}";
    }
}

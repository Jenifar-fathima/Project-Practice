namespace Project_ExercisesLogic;

public static class CountCharacter
{
    public static int CountMethod(string strName)
    {
        int nCount = 0;
        foreach(char c in strName)
        {
            nCount++;
        }
        return nCount;
    }
}

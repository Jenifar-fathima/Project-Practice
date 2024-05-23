namespace Project_ExercisesLogic;

public static class PasswordValidation
{
    public static string ValidationMethod(string strUserName, string strPassword)
    {
        string strDefaultUserName = "UserName";
        string strDefaultPassword = "abc$123";

        string strResult = strUserName == strDefaultUserName && strPassword == strDefaultPassword ? "Welcome!" : "I don't know you.";
        
        return strResult;

    }
}

namespace Project_ExercisesLogic;
[TestClass]
public class LegalDrivingAgeTest
{
    [TestMethod]
    public void Test_DrivingMethod1()
    {
        string strUserInput = "27";

        string strResult = LegalDrivingAge.AgeMethod(strUserInput);
        Assert.AreEqual("You are old enough to legally drive.", strResult);
    }
    [TestMethod]
    public void Test_DrivingMethod2()
    {
        string strUserInput = "15";

        string strResult = LegalDrivingAge.AgeMethod(strUserInput);
        Assert.AreEqual("You are not old enough to legally drive.", strResult);
    }
    [TestMethod]
    public void Test_DrivingMethod3()
    {
        string strUserInput = "abc";

        string strResult = LegalDrivingAge.AgeMethod(strUserInput);
        Assert.AreEqual("Invalid input. Please enter a valid age.", strResult);
    }
}

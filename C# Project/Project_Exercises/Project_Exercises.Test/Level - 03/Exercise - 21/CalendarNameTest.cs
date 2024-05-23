namespace Project_ExercisesLogic;
[TestClass]
public  class CalendarNameTest
{
    [TestMethod]
    public void Test_CalenderMethod()
    {
        //testcase 1
        string strResult1 = CalendarName.SampleMethod(3);
        Assert.AreEqual("The name of the month is March.", strResult1);

        //testcase 2
        string strResult2 = CalendarName.SampleMethod(7);
        Assert.AreEqual("The name of the month is July.", strResult2);

        //testcase 3
        string strResult3 = CalendarName.SampleMethod(13);
        Assert.AreEqual("Enter a number between 1 to 12.", strResult3);
    }
}

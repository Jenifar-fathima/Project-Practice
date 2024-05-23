namespace Project_ExercisesLogic;
[TestClass]
public class ComparingNumberTest
{
    [TestMethod]
    public void Test_Method()
    {
        int[] lstMethod1 = { 1, 21, 52, 100, 2, 3, 4, 10};
        string strResult1 = ComparingNumber.ComparingMethod(lstMethod1);
        Assert.AreEqual("The largest number is 100", strResult1);

        int[] lstMethod2 = {};
        string strResult2 = ComparingNumber.ComparingMethod(lstMethod2);
        Assert.AreEqual("Array is empty or null", strResult2);
    }
}

namespace Project_ExercisesLogic;
[TestClass]
public class TemperatureConverterTest
{
    [TestMethod]
    public void Test_Method()
    {
        //Test Case 1
        string strResult1 = TemperatureConverter.ConvertorMethod(0,"F");
        Assert.AreEqual("The temperature in Fahrenheit is 32.", strResult1);

        //Test Case 2
        string strResult2 = TemperatureConverter.ConvertorMethod(32,"C");
        Assert.AreEqual("The temperature in Celsius is 0.", strResult2);

        //Test Case 3
        string strResult3 = TemperatureConverter.ConvertorMethod(12, "H");
        Assert.AreEqual("Invalid Unit! Please enter the correct unit", strResult3);
    }
}

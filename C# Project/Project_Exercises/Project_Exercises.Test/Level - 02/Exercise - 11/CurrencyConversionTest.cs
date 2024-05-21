namespace Project_ExercisesLogic;
[TestClass]
public class CurrencyConversionTest
{
    [TestMethod]
    public void Test_ConversionMethod()
    {
        double nEuroAmount = 81;
        double nEuroRate = 137.51;

        string strResult = CurrencyConversion.ConversionMethod(nEuroAmount, nEuroRate);
        Assert.AreEqual("81 euros at an exchange rate of 137.51 is 111.38 U.S. dollars.", strResult);
    }
}

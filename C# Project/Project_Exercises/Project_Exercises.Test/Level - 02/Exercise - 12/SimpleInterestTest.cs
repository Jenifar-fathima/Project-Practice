using System.Diagnostics.Metrics;

namespace Project_ExercisesLogic;
[TestClass]
public class SimpleInterestTest
{
    [TestMethod]
    public void Test_CalculationMethod()
    {
        double nPrincipal = 1500;
        double nRate = 4.3;
        double nTime = 4;

        string strResult = SimpleInterest.SimpleInterestCalculator(nPrincipal, nRate, nTime);   
        Assert.AreEqual("After 4 years at 4.3 %, the investment will be worth $1758.", strResult);
    }
}

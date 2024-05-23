namespace Project_ExercisesLogic;
[TestClass]
public class CompoundInterestTest
{
    [TestMethod]
    public void Test_Calculation()
    {
        double nPrincipal = 1500;
        double nRate = 4.3/100;
        int nTime = 6;
        int nCount = 4;

        string strResult = CompoundInterest.InterestCalculationMethod(nPrincipal, nRate, nTime, nCount);
        Assert.AreEqual("$1500 invested at 4.3% for 6 years compounded 4 times per year is $1938.84.", strResult);
    }
}

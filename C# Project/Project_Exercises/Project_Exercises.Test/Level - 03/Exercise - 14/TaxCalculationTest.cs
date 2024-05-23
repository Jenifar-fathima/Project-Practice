namespace Project_ExercisesLogic;
[TestClass]
public  class TaxCalculationTest
{
    [TestMethod]
    public void  Test_CalulatorMethod()
    {
        int nAmount = 10;
        
        string strResult1 = TaxCalculation.CalulatorMethod(nAmount, "WI");
        Assert.AreEqual("The subtotal is $10.00.\nThe tax is $0.55.\nThe total is $10.55.", strResult1);

        string strResult2 = TaxCalculation.CalulatorMethod(nAmount, "MN");
        Assert.AreEqual("The total is $10.00.", strResult2);

        string strResult3 = TaxCalculation.CalulatorMethod(nAmount, "CA");
        Assert.AreEqual("Invalid State", strResult3);
    }
}


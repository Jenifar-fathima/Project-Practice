namespace Project_ExercisesLogic;
[TestClass]
public  class SalesTaxCalculatorTest
{
    [TestMethod]
    public void Test_CalculationMethod()
    {
        //TESTCASE 1
        string strResult1 = SalesTaxCalculator.CalculationMethod("Wisconsin", "Eau Claire", 10);
        Assert.AreEqual("The tax is $0.50. The total is $10.50.", strResult1);

        //TESTCASE 2
        string strResult2 = SalesTaxCalculator.CalculationMethod("Wisconsin", "Dunn", 10);
        Assert.AreEqual("The tax is $0.40. The total is $10.40.", strResult2);

        //TESTCASE 3
        string strResult3 = SalesTaxCalculator.CalculationMethod("Wisconsin", "OtherCountry", 10);
        Assert.AreEqual("Enter Valid Country name", strResult3);

        //TESTCASE 4
        string strResult4 = SalesTaxCalculator.CalculationMethod("Illinois", "", 10);
        Assert.AreEqual("The tax is $0.80. The total is $10.80.", strResult4);

        //TESTCASE 5
        string strResult5 = SalesTaxCalculator.CalculationMethod("OtherState", "", 10);
        Assert.AreEqual("The total is $10.00", strResult5);

    }
}

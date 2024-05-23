namespace Project_ExercisesLogic;
[TestClass]
public  class AreaCalculatorTest
{
    [TestMethod]
    public void CalulatorMethod()
    {
        int nLength = 15;
        int nWidth = 20;
        
        string strResult = TaxCalculator.CalulatorMethod(nLength, nWidth);
        Assert.AreEqual("You entered dimensions of 15 feet by 20 feet.\r\nThe area is\r\n300 square feet\r\n27.871 square meters", strResult);
    }
}


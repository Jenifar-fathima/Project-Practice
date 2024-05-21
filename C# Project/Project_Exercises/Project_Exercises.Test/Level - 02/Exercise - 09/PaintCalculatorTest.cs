namespace Project_ExercisesLogic;
[TestClass]
public class PaintCalculatorTest
{
    [TestMethod]
    public void Test_CalculatorMethod()
    {
        int nLength = 17;
        int nWidth = 20;

        string strResult = PaintCalculator.CalculatorMethod(nLength, nWidth);
        Assert.AreEqual("You will need to purchase 1 gallons of paint to cover 340 square feet.", strResult);
    }
}

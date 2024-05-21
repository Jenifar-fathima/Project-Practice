namespace Project_ExercisesLogic;
[TestClass]
public class BMICalculatorTest
{
    [TestMethod]
    public void Test_CalculatonMethod()
    {
        string strResult1 = BMICalculator.CalculatonMethod(68.90, 131.61);
        Assert.AreEqual("You are within the ideal weight range.", strResult1);

        string strResult2 = BMICalculator.CalculatonMethod(68.90, 219.45);
        Assert.AreEqual("You are overweight. You should see your doctor.", strResult2);

        string strResult3 = BMICalculator.CalculatonMethod(60.10, 80.61);
        Assert.AreEqual("You are underweight. You should see your doctor.", strResult3);
    }
}

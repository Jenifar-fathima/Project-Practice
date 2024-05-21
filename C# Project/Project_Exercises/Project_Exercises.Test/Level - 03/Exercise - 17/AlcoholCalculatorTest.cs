namespace Project_ExercisesLogic;
[TestClass]
public class AlcoholCalculatorTest
{
    [TestMethod]
    public void Test_Calculator()
    {
        // Test Case 1 - Legal to Drive
        string bac1 = AlcoholCalculator.CalculateBAC(150, "Male", 2, 12, 2);
        Assert.AreEqual("It is legal for you to drive.", bac1);

        // Test Case 2 - Not Legal to Drive
        string bac2 = AlcoholCalculator.CalculateBAC(120, "Female", 3, 8, 1.5);
        Assert.AreEqual("It is not legal for you to drive.", bac2);

        // Test Case 3 - Not Legal to Drive
        string bac3 = AlcoholCalculator.CalculateBAC(180, "Male", 4, 16, 0.5);
        Assert.AreEqual("It is not legal for you to drive.", bac3);
    }
}

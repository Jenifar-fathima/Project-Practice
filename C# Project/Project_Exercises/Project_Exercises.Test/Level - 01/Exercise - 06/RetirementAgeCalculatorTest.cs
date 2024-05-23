namespace Project_ExercisesLogic;
[TestClass]
    public class RetirementAgeCalculatorTest
    {
    [TestMethod]
        public void Test_AgeCalculatorMethod()
        {
        int nRetirementAge = 35;
        int nCurrentAge = 25;

        string strResult = RetirementAgeCalculator.AgeCalculatorMethod(nCurrentAge, nRetirementAge);
        Assert.AreEqual("You have 10 years left before you can retire.\r\nIt's 2024, so you can retire in 2034.", strResult);
    }
}


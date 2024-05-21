namespace Project_ExercisesLogic;
[TestClass]
public class BasicCalculationTest
{
    [TestMethod]
    public void Test_BasicCalculationMethod()
    {
        int nNumber1 = 7;
        int nNumber2 = 3;

        string nResult = BasicCalculation.CalculationMethod(nNumber1, nNumber2);
        Assert.AreEqual("[\n\t\"7 + 3 = 10\",\n\t\"7 - 3 = 4\",\n\t\"7 * 3 = 21\",\n\t\"7 / 3 = 2\",\n\t\"7 % 3 = 1\"\n]", nResult);
    }
}                                          
                        
                        
                        
                        
namespace Project_ExercisesLogic;
[TestClass]
public class PizzaPartyTest
{
    [TestMethod]
    public void Test_PizzaPartyMethod()
    {
        int nPeopleCount = 9;
        int nPizzaCount = 2;
        int nSliceCount = 8;

        string strResult = PizzaParty.PizzaCalculationMethod(nPeopleCount, nPizzaCount, nSliceCount);
        Assert.AreEqual("9 people with 2 pizzas\r\nEach person gets 1 pieces of pizza.\r\nThere are 7 leftover pieces.", strResult);
    }
}


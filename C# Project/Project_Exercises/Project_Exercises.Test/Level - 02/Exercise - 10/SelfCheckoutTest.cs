namespace Project_ExercisesLogic;
[TestClass]
public class SelfCheckoutTest
{
    [TestMethod]
    public void Test_CalculationMethod()
    {
        int[] nPrice = { 25, 10, 4 };
        int[] nQuantity = { 2, 1, 1 };

        string strResult = SelfCheckout.CalculationMethod(nPrice, nQuantity);
        Assert.AreEqual("Subtotal: $64.00\nTax: $3.52\nTotal: $67.52", strResult);
    }
}

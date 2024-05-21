namespace Project_ExercisesLogic;
[TestClass]
public class PasswordValidationTest
{
    [TestMethod]
    public void Test_ValidationMethod1()
    {
        string strResult1 = PasswordValidation.ValidationMethod("UserName", "abc$123");
        Assert.AreEqual("Welcome!", strResult1);

        string strResult2 = PasswordValidation.ValidationMethod("UserName", "123456");
        Assert.AreEqual("I don't know you.", strResult2);
    }
}

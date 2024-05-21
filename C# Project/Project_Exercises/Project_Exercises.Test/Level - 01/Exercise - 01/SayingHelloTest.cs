using Project_ExercisesLogic;

namespace Project_ExercisesTest;

[TestClass]
public class SayingHelloTest
{
    #region Tests
    [TestMethod]
    public void TestSayingHello()
    {
        // Arrange
        const string NAME_DOREMON = "Doremon";

        // Act
        string strMessage = SayingHello.Solution(NAME_DOREMON);

        // Assert
        Assert.AreEqual("Hello Doremon, nice to meet you!", strMessage);
    }
    #endregion
}
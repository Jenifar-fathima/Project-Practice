namespace Project_ExercisesLogic;

[TestClass]
public class CountCharacterTest
{
    #region Tests
    [TestMethod]
    public void TestCountCharacter()
    {
        // Arrange
        const string NAME_DOREMON = "Doremon";

        // Act
        int nWordCount = CountCharacter.CountMethod(NAME_DOREMON);

        // Assert
        Assert.AreEqual(7, nWordCount);
    }
    #endregion
}

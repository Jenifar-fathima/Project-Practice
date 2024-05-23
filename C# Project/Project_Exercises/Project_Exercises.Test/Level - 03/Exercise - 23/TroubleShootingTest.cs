namespace Project_ExercisesLogic;

[TestClass]
public class TroubleShootingTest
{
    [TestMethod]
    public void Test_Method1()
    {
        // Arrange
        bool isSilent = true;
        bool corrodedTerminals = true;
        bool clickingNoise = false;
        bool crankNoStart = false;
        bool engineStartDie = false;
        bool hasFuelInjection = true;

        // Act
        string result = TroubleShooting.TroubleshootIssue(isSilent, corrodedTerminals, clickingNoise, crankNoStart, engineStartDie, hasFuelInjection);

        // Assert
        Assert.AreEqual("Clean terminals and try starting again.", result);
    }
}

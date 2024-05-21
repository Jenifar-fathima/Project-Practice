namespace Project_ExercisesLogic;
[TestClass]
    public class MadLibTest
    {
    [TestMethod]
    public void Test_MadLibMethod() 
    {
        string strNoun = "Doremon";
        string strVerb = "dance";
        string strAdjective = "blue";
        string strAdverb = "beautifully";

        string strResult = MadLib.MadLibMethod(strNoun, strVerb, strAdjective, strAdverb);
        Assert.AreEqual("Do you dance your blue Doremon beautifully? That's hilarious!", strResult);
    }                                           
}                                              
                                                
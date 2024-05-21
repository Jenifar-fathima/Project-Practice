namespace Project_ExercisesLogic;

[TestClass]
public class QuoteWriterTest
{
    [TestMethod]
    public void TestQuoteWriterMethod()
    {
        string strAuthor = "Jenifar";
        string strQuote = "I'm Jenifar";

        string strResult = QuoteWriter.QuoteWriterMethod(strAuthor, strQuote);
        Assert.AreEqual("Jenifar says, \"I'm Jenifar\"", strResult);
    }
}
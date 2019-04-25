using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleValuesModels;

namespace ScrabbleValuesTests
{
  [TestClass]
  public class ScrabbleValueTest
  {
    [TestMethod]
    public void GetScrabbleValue_GetsValue_int()
    {
      //Arrange
      string word = "a";
      ScrabbleValues newScrabbleValues = new ScrabbleValues();

      //Act
      int wordValue = 1;
      newScrabbleValues.SetScrabbleValues(wordValue);
      int result = newScrabbleValues.GetWord();

      //Assert
      Assert.AreEqual(wordValue, result);
    }
    [TestMethod]
    public void GetScrabbleValue_GetsValue_int()
    {
      //Arrange
      string word = "a";
      ScrabbleValues newScrabbleValues = new ScrabbleValues();

      //Act
      int wordValue = 1;
      newScrabbleValues.SetScrabbleValues(wordValue);
      int result = newScrabbleValues.GetWord();

      //Assert
      Assert.AreEqual(wordValue, result);
    }
  }
}

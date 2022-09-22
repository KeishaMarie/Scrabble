using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;
using System;
using System.Collections.Generic;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void ScoreCheck_InitializeScoreCheck_NewGame()
    {
      Scrabble newScrabble = new Scrabble("SCRABBS");
      Assert.AreEqual(typeof(Scrabble), newScrabble.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      //ARRANGE
      string description = "word";
      //ACT
      Scrabble newScrabble = new Scrabble(description);
      //ASSERT
      Assert.AreEqual("WORD", newScrabble.Description);
    } 
    [TestMethod]
    public void CheckScore_TurnsStringToArray_True()
    {
      Scrabble newScrabble = new Scrabble("ban");
      char[] banArray = new char[] {'B', 'A', 'N'};
      char[] uInput = newScrabble.Description.ToCharArray();
      CollectionAssert.AreEqual(banArray, uInput);
    }

    [TestMethod]
    public void CheckScore_CalculatesScore_TotalScore()
    {
      // ARRANGE
      Scrabble newScrabble = new Scrabble("bananas");
      //ACT
      // newScrabble.CheckScore();
      Scrabble.CheckScore("bananas");
      //ASSERT
      Assert.AreEqual(9, Scrabble.Score);
    }
  }
}
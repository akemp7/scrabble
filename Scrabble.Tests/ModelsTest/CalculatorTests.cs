using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleCalculator.Models;

namespace ScrabbleCalculator.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void WordCalculator_CalculatesValueOfWord_5()
        {
            //arrange
            string userWord = "cat";
            //act
            Scrabble newScrabble = new Scrabble(userWord);
            newScrabble.Calculator();
            int result = newScrabble.Score;
            //assert
            Assert.AreEqual(5, result);
        }
    }
}
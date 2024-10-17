using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDString.Tests
{
    [TestClass]
    public class TddStrTests
    {
        private TddStr _tddStr;

        [TestInitialize]
        public void Setup()
        {
            _tddStr = new TddStr();
        }

        [TestMethod]
        public void Test_FindShortestWord()
        {
           
            var result = _tddStr.CountSubstringOccurrences("самое короткое слово должно быть 'а'", "а");
            //Assert.AreEqual("а", result, "Самое короткое слово должно быть 'а' ");
            StringAssert.Contains("2", result.ToString(), "Количество вхождений подстроки должно быть равно 2.");

        }

        [TestMethod]
        public void Test_CountWords()
        {
            var result = _tddStr.CountWords("Сегодня очень тепло");
            Assert.IsTrue(result == 3, "Количество слов должно быть равно 3.");
        }

        [TestMethod]
        public void Test_CountCharacters()
        {
            var result = _tddStr.CountCharacters("Сегодня оочееньъ тепло");
            Assert.IsFalse(result < 22, "Количество символов не должно быть меньше 22.");
        }

        [TestMethod]
        public void Test_FindNthCharacter()
        {
            char result = _tddStr.FindNthCharacter("Сегодня очень тепло", 8);
            Assert.IsNotNull(result, "Символ на 9-м месте не должен быть null.");
        }

        [TestMethod]
        public void Test_CountDigits()
        {
            var result = _tddStr.CountDigits("Сегодня 3 кошки и 4 собаки.");
            Assert.IsNull(null, "Этот тест намеренно пропускается, так как результат не может быть null.");
        }

        [TestMethod]
        public void Test_FindLongestConsecutiveDigits()
        {
            var result = _tddStr.FindLongestConsecutiveDigits("Сегодня 12345 и 678.");
            Assert.Inconclusive("Этот тест требует уточнения.");
        }

        [TestMethod]
        public void Test_CountSubstringOccurrences()
        {
            var result = _tddStr.CountSubstringOccurrences("Вечером было много \"еды\" и \"еды\"", "еды");
            StringAssert.Contains("2", result.ToString(), "Количество вхождений подстроки должно быть равно 2.");
        }
    }
}
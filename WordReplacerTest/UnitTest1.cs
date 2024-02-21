using WordReplacer;

namespace WordReplacerTest
{
    [TestClass]
    public class WordReplacerTest
    {
        [TestMethod]
        public void ReplaceWordTest()
        {
            string input = "Это тестовая строка";
            string expectedValue = "Это тестовая стринга";
            Replacer replacer = new(input);

            string result = replacer.ReplaceSpecificWordWithOtherWord("строка", "стринга");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ReplaceWordWithMultilineInput()
        {
            string[] input = { "Это первое предложение", "Это второе предложение" };
            string expectedValue = "Это первое элемент. Это второе элемент";
            Replacer replacer = new(input);

            string result = replacer.ReplaceSpecificWordWithOtherWord("предложение", "элемент");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ожидалось ненулевое значение.")]
        public void ReplaceWordWithNullValueInput()
        {
            string input = null;
            Replacer replacer = new(input);
            replacer.ReplaceSpecificWordWithOtherWord("слово", "словечко");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ожидалась непустая строка.")]
        public void ReplaceWordWithEmptyStringInput()
        {
            string input = "";
            Replacer replacer = new(input);
            replacer.ReplaceSpecificWordWithOtherWord("слово", "словечко");
        }
    }
}
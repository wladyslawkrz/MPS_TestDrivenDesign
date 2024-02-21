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

            string result = input.ReplaceSpecificWordWithOtherWord("строка", "стринга");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ReplaceWordWithMultilineInput()
        {
            string[] input = { "Это первое предложение", "Это второе предложение" };
            string[] expectedValue = { "Это первое элемент", "Это второе элемент" };

            string[] result = input.ReplaceSpecificWordWithOtherWord("предложение", "элемент");

            Assert.AreEqual(String.Join(". ", expectedValue), String.Join(". ", result));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ожидалось ненулевое значение.")]
        public void ReplaceWordWithNullValueInput()
        {
            string input = null;
            input.ReplaceSpecificWordWithOtherWord("слово", "словечко");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "Ожидалась непустая строка.")]
        public void ReplaceWordWithEmptyStringInput()
        {
            string input = "";
            input.ReplaceSpecificWordWithOtherWord("слово", "словечко");
        }
    }
}
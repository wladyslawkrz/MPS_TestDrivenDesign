using WordReplacer;

namespace WordReplacerTest
{
    [TestClass]
    public class WordReplacerTest
    {
        [TestMethod]
        public void ReplaceWordTest()
        {
            string input = "��� �������� ������";
            string expectedValue = "��� �������� �������";
            Replacer replacer = new(input);

            string result = replacer.ReplaceSpecificWordWithOtherWord("������", "�������");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ReplaceWordWithMultilineInput()
        {
            string[] input = { "��� ������ �����������", "��� ������ �����������" };
            string expectedValue = "��� ������ �������. ��� ������ �������";
            Replacer replacer = new(input);

            string result = replacer.ReplaceSpecificWordWithOtherWord("�����������", "�������");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "��������� ��������� ��������.")]
        public void ReplaceWordWithNullValueInput()
        {
            string input = null;
            Replacer replacer = new(input);
            replacer.ReplaceSpecificWordWithOtherWord("�����", "��������");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "��������� �������� ������.")]
        public void ReplaceWordWithEmptyStringInput()
        {
            string input = "";
            Replacer replacer = new(input);
            replacer.ReplaceSpecificWordWithOtherWord("�����", "��������");
        }
    }
}
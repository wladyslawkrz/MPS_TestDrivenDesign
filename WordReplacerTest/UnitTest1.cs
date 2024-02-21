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

            string result = input.ReplaceSpecificWordWithOtherWord("������", "�������");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        public void ReplaceWordWithMultilineInput()
        {
            string[] input = { "��� ������ �����������", "��� ������ �����������" };
            string expectedValue = "��� ������ �������. ��� ������ �������";

            string result = input.ConcatSentences().ReplaceSpecificWordWithOtherWord("�����������", "�������");

            Assert.AreEqual(expectedValue, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "��������� ��������� ��������.")]
        public void ReplaceWordWithNullValueInput()
        {
            string input = null;
            input.ReplaceSpecificWordWithOtherWord("�����", "��������");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "��������� �������� ������.")]
        public void ReplaceWordWithEmptyStringInput()
        {
            string input = "";
            input.ReplaceSpecificWordWithOtherWord("�����", "��������");
        }
    }
}
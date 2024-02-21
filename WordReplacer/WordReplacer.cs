namespace WordReplacer
{
    public static class ReplacerExtension
    {
        public static string ReplaceSpecificWordWithOtherWord(this string _input, string wordToReplace, string otherWord)
        {
            if (_input == null)
            {
                throw new ArgumentException("Ожидалось ненулевое значение.");
            }

            if (_input.Length == 0)
            {
                throw new ArgumentException("Ожидалась непустая строка.");
            }

            string result = _input.Replace(wordToReplace, otherWord);

            return result;
        }

        public static string ConcatSentences(this string[] _input)
        {
            return String.Join(". ", _input);
        }
    }
}
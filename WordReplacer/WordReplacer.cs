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

        public static string[] ReplaceSpecificWordWithOtherWord(this string[] _input, string wordToReplace, string otherWord)
        {
            string[] result = new string[_input.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = _input[i].Replace(wordToReplace, otherWord); 
            }

            return result;
        }
    }
}
namespace WordReplacer
{
    public class Replacer
    {
        private readonly string _text;

        public Replacer(dynamic input)
        {
            if (input is string[])
            {
                _text = String.Join(". ", input);
            }

            if (input is string) { _text = input; }
        }

        public string ReplaceSpecificWordWithOtherWord(string wordToReplace, string otherWord)
        {
            if (_text == null)
            {
                throw new ArgumentException("Ожидалось ненулевое значение.");
            }

            if (_text.Length == 0)
            {
                throw new ArgumentException("Ожидалась непустая строка.");
            }

            string result = _text.Replace(wordToReplace, otherWord);

            return result;
        }
    }
}
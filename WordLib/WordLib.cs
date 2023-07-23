namespace WordLib
{
    public static class WordLib
    {
        public static bool IsWordPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("Please enter a word.");

            word = word.ToLower();

            int fromRight = word.Length - 1;
            int fromLeft = 0;

            while (fromLeft < fromRight)
            {
                if (word[fromLeft] != word[fromRight])
                    return false;

                fromLeft++;
                fromRight--;
            }

            return true;
        }

        public static bool IsWordAtleastTenCharacters(string word)
        {
            if (word.Length >= 10)
            {
                return true;
            }
            return false;
        }

    }
}
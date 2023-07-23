﻿namespace WordLib
{
    public static class WordLib
    {
        public static bool IsWordPalindrome(string word)
        {
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


    }
}
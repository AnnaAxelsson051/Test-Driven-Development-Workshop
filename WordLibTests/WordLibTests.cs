using WordLib;

namespace WordLibTests
{
    public class WordLibTests
    {
        
        [Fact]
            public void IsWordPalindrome_ReturnsTrue_ForPalindromeWord()
        {
            var result = WordLib.WordLib.IsWordPalindrome("deed");
            Assert.True(result);
        }

        [Fact]
        public void IsWordPalindrome_NonPalindromeWord_ReturnsFalse()
        {
            var result = WordLib.WordLib.IsWordPalindrome("cat");
            Assert.False(result);
        }

        [Fact]
        public void IsWordPalindrome_AllSameCharacters_ReturnsTrue()
        {
            var result = WordLib.WordLib.IsWordPalindrome("gggg");
            Assert.True(result);
        }

        [Fact]
        public void IsWordPalindrome_CaseInsensitive_ReturnsTrue()
        {
            var result = WordLib.WordLib.IsWordPalindrome("Tenet");
            Assert.True(result);
        }

    }
}
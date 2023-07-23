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

        [Fact]
        public void IsWordPalindrome_EmptyString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(
                () => WordLib.WordLib.IsWordPalindrome(""));
        }

        [Fact]
        public void IsWordAtleastTenCharacters_test()
        {
            bool result = WordLib.WordLib.IsWordAtleastTenCharacters("Medborgarplatsen");
            Assert.True(result);
        }

        [Theory]
        [InlineData(6)]
        [InlineData(14)]
        [InlineData(24)]
        [InlineData(26)]
        public void IsNumberEven_ReturnsTrue_ForEvenNumbers(int number)
        {
            var result = WordLib.WordLib.IsNumberEven(number);
            Assert.True(result);
        }
    }
}
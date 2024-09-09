using Xunit;
using ProjectTwo;

namespace ProjectTwo.Tests
{
    public class StringProcessorTests
    {
        [Fact]
        public void CountVowels_ShouldReturnCorrectCount()
        {
            var processor = new StringProcessor();
            int result = processor.CountVowels("hello");
            Assert.Equal(2, result);
        }

        [Fact]
        public void Reverse_ShouldReturnReversedString()
        {
            var processor = new StringProcessor();
            string result = processor.Reverse("hello");
            Assert.Equal("olleh", result);
        }

        [Fact]
        public void CountVowels_EmptyString_ShouldReturnZero()
        {
            var processor = new StringProcessor();
            int result = processor.CountVowels("");
            Assert.Equal(0, result);
        }

        [Fact]
        public void Reverse_EmptyString_ShouldReturnEmptyString()
        {
            var processor = new StringProcessor();
            string result = processor.Reverse("");
            Assert.Equal("", result);
        }
    }
}

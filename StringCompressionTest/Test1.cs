using Xunit;
using Assigment3Dotnet;  

namespace StringCompressionTest
{
    public class StringCompressorTests
    {
        [Fact]
        public void Test_EmptyString()
        {
            var compressor = new StringCompressor();
            Xunit.Assert.Equal("", compressor.Compress(""));
        }

        [Fact]
        public void Test_NoConsecutiveCharacters()
        {        
            var compressor = new StringCompressor();
            Xunit.Assert.Equal("abc", compressor.Compress("abc"));
        }

        [Fact]
        public void Test_ConsecutiveCharacters()
        {
            var compressor = new StringCompressor();
            Xunit.Assert.Equal("a2b1c5a3", compressor.Compress("aabcccccaaa"));
        }

        [Fact]
        public void Test_CompressionNotReducingSize()
        {
            var compressor = new StringCompressor();
            Xunit.Assert.Equal("abcd", compressor.Compress("abcd"));
        }
    }
}



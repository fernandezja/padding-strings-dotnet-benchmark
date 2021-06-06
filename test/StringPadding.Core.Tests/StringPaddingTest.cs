using System;
using Xunit;

namespace StringPadding.Core.Tests
{
    public class StringPaddingTest
    {
        private StringPadding _stringPadding;

        public StringPaddingTest()
        {
            _stringPadding = new StringPadding();
        }

        [Fact]
        public void PadRight_Simple()
        {
            var result = _stringPadding.PadRight("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        [Fact]
        public void PadRightWithConcat_Simple()
        {
            var result = _stringPadding.PadRightWithConcat("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        [Fact]
        public void PadRightWithInterpolation_Simple()
        {
            var result = _stringPadding.PadRightWithInterpolation("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        [Fact]
        public void PadRightWithConcatEnumerableRepeat_Simple()
        {
            var result = _stringPadding.PadRightWithConcatEnumerableRepeat("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        [Fact]
        public void PadRightWithInterpolationEnumerableRepeat_Simple()
        {
            var result = _stringPadding.PadRightWithInterpolationEnumerableRepeat("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        [Fact]
        public void PadRightWithCharArray_Simple()
        {
            var result = _stringPadding.PadRightWithCharArray("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }


        [Fact]
        public void PadRightWithStringBuilder_Simple()
        {
            var result = _stringPadding.PadRightWithStringBuilder("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }


        [Fact]
        public void PadRightWithStringBuilderInsert_Simple()
        {
            var result = _stringPadding.PadRightWithStringBuilderInsert("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        [Fact]
        public void PadRightWithReadOnlySpan_Simple()
        {
            var result = _stringPadding.PadRightWithReadOnlySpan("Starwars", totalWidth: 10, paddingChar: '!');

            Assert.Equal("Starwars!!", result);
        }

        



    }
}

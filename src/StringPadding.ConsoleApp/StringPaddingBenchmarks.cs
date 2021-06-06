using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringPadding.ConsoleApp
{
    [MemoryDiagnoser]
    public class StringPaddingBenchmarks
    {
        private const string STRING_TO_PADDING = "The Force will be with you always";
        private const int TOTAL_WIDTH = 10000;
        private const char PADDING_CHAR = '!';

        private static readonly Core.StringPadding _stringPadding = new Core.StringPadding();

        [Benchmark(Baseline = true)]
        public void PadRight()
        {
            _ = _stringPadding.PadRight(STRING_TO_PADDING, 
                                    totalWidth: TOTAL_WIDTH, 
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithConcat()
        {
            _ = _stringPadding.PadRightWithConcat(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithInterpolation()
        {
            _ = _stringPadding.PadRightWithInterpolation(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithConcatEnumerableRepeat()
        {
            _ = _stringPadding.PadRightWithConcatEnumerableRepeat(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithInterpolationEnumerableRepeat()
        {
            _ = _stringPadding.PadRightWithInterpolationEnumerableRepeat(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithCharArray()
        {
            _ = _stringPadding.PadRightWithCharArray(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }
        

        [Benchmark]
        public void PadRightWithStringBuilder()
        {
            _ = _stringPadding.PadRightWithStringBuilder(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithStringBuilderInsert()
        {
            _ = _stringPadding.PadRightWithStringBuilderInsert(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        [Benchmark]
        public void PadRightWithReadOnlySpan()
        {
            _ = _stringPadding.PadRightWithReadOnlySpan(STRING_TO_PADDING,
                                    totalWidth: TOTAL_WIDTH,
                                    paddingChar: PADDING_CHAR);
        }

        


    }
}

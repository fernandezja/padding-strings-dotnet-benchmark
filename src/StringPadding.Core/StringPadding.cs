using System;
using System.Linq;
using System.Text;

namespace StringPadding.Core
{
    public class StringPadding
    {
        public string PadRight(string inputText, int totalWidth, char paddingChar)
        {
            return inputText.PadRight(totalWidth: totalWidth, paddingChar: paddingChar);
        }

        public string PadRightWithConcat(string inputText, int totalWidth, char paddingChar)
        {
            return string.Concat(inputText, new string(paddingChar, totalWidth - inputText.Length));
        }

        public string PadRightWithInterpolation(string inputText, int totalWidth, char paddingChar)
        {
            return $"{inputText}{new string(paddingChar, totalWidth - inputText.Length)}";
        }

        public string PadRightWithConcatEnumerableRepeat(string inputText, int totalWidth, char paddingChar)
        {
            return string.Concat(inputText, string.Concat(Enumerable.Repeat(paddingChar, totalWidth - inputText.Length)));
        }

        public string PadRightWithInterpolationEnumerableRepeat(string inputText, int totalWidth, char paddingChar)
        {
            return $"{inputText}{string.Concat(Enumerable.Repeat(paddingChar, totalWidth - inputText.Length))}";
        }

        public string PadRightWithCharArray(string inputText, int totalWidth, char paddingChar)
        {
            var times = totalWidth - inputText.Length;

            int limit = (int)Math.Log(times, 2);
            char[] buffer = new char[times];
            int width = 1;
            Array.Copy(new char[1] { paddingChar }, buffer, 1);

            for (int index = 0; index < limit; index++)
            {
                Array.Copy(buffer, 0, buffer, width, width);
                width *= 2;
            }

            char[] inputBuffer = new char[totalWidth];

            Array.Copy(inputText.ToCharArray(), inputBuffer, inputText.Length);
            Array.Copy(buffer, 0, inputBuffer, inputText.Length, times);

            return new string(inputBuffer);
        }

        public string PadRightWithStringBuilder(string inputText, int totalWidth, char paddingChar)
        {
            var sb = new StringBuilder(inputText);
            
            for (int i = 0; i < (totalWidth - inputText.Length); i++)
            {
                sb.Append(paddingChar);
            }

            return sb.ToString();
        }

        public string PadRightWithStringBuilderInsert(string inputText, int totalWidth, char paddingChar)
        {
            var sb = new StringBuilder(inputText);

            sb.Insert(inputText.Length, paddingChar.ToString(), totalWidth - inputText.Length);

            return sb.ToString();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DevTree.BeKurdi.Unicode;

namespace DevTree.BeKurdi
{
    public static class SoraniNormalization
    {
        private const int MaxWordLength = 50;

        public static string Normalize(this string text)
        {
            var builder = new StringBuilder(text);


            builder.Replace($"{Yeh}{ArabicFatha}", $"{YehWithSmallV}")
                   .Replace($"{ArabicLetterYeh}{ArabicFatha}", $"{YehWithSmallV}")
                   .Replace($"{ArabicLetterAlefMaksura}{ArabicFatha}", $"{YehWithSmallV}");

            builder.Replace($"{Waw}{ArabicFatha}", $"{Oe}");

            builder.Replace($"{Heh}{ZeroWidthNonJoiner}", $"{Ae}");

            builder.Replace($"{Reh}{ArabicKasra}", $"{RehWithSmallV}");

            builder.Replace(ArabicLetterTah, Gaf)
                   .Replace(ArabicLetterKaf, Kaf)
                   .Replace(ArabicLetterDad, Tcheh)
                   .Replace(ArabicLetterZah, Veh)
                   .Replace(ArabicLetterTheh, Peh)
                   .Replace(ArabicLetterThal, Jeh)
                   .Replace(ArabicLetterWawWithHamzaAbove, Oe)
                   .Replace(ArabicLetterHehDoachashmee, Heh)
                   .Replace(ArabicLetterAlefWithHamzaAbove, Alef)
                   .Replace(ArabicLetterAlefWithMaddaAbove, Alef)
                   .Replace(ArabicLetterTehMarbuta, Ae)
                   .Replace(ArabicLetterYeh, Yeh)
                   .Replace(ArabicLetterAlefMaksura, Yeh);

            int startIndex = 0;
            int endIndex = 0;

            while (endIndex < builder.Length)
            {
                endIndex = builder.Length - startIndex <= MaxWordLength ? builder.Length : endIndex;
                bool exitLoop = endIndex > 0;
                while ((endIndex - startIndex) < MaxWordLength && endIndex < builder.Length)
                {
                    switch (builder[endIndex])
                    {
                        case Space:
                        case FullStop:
                        case SoraniSemicolon:
                        case Semicolon:
                        case SoraniQuestionMark:
                        case LatinQuestionMark:
                            exitLoop = true;
                            break;
                    }

                    endIndex++;

                    if (exitLoop) break;
                }

                for (int i = startIndex; i < endIndex; i++)
                {
                    switch (builder[i])
                    {
                        case Hamza:
                            endIndex += NormalizeHamza(builder, startIndex, endIndex);
                            break;
                        case Alef:
                            endIndex += NormalizeInitialAlef(builder, startIndex, endIndex);
                            break;
                        case Reh:
                            endIndex += NormalizeInitialRe(builder, startIndex, endIndex);
                            break;
                    }
                }

                startIndex = endIndex;
            }

            return builder.ToString();
        }

        #region Transformation Functions
        private static int NormalizeHamza(StringBuilder builder, int startIndex, int limit)
        {
            for (int i = startIndex; i < limit; i++)
            {
                if (builder[i] != Hamza)
                    continue;

                if (i != startIndex && (i + 1 == limit || !AllSoraniAlphabetVowls.Contains(builder[i + 1])))
                {
                    builder[i] = YehWithSmallV;
                    continue;
                }
            }

            return 0;
        }

        private static int NormalizeInitialAlef(StringBuilder builder, int startIndex, int limit)
        {
            if (limit - startIndex <= 1 || builder[0] != Alef)
                return 0;

            builder.Insert(0, Hamza);
            return 1;
        }

        private static int NormalizeInitialRe(StringBuilder builder, int startIndex, int limit)
        {
            if (builder[startIndex] == Reh)
                builder[startIndex] = RehWithSmallV;


            return 0;
        }
        #endregion
    }
}

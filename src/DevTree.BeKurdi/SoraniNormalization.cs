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

            // Simple replacements
            builder.Replace(ArabicLetterTah, Gaf)                   // ط => گ
                   .Replace(ArabicLetterKaf, Kaf)                   // ك => ک
                   .Replace(ArabicLetterDad, Tcheh)                 // ض => چ
                   .Replace(ArabicLetterZah, Veh)                   // ظ => ڤ
                   .Replace(ArabicLetterTheh, Peh)                  // ث => پ
                   .Replace(ArabicLetterThal, Jeh)                  // ذ => ژ
                   .Replace(ArabicLetterWawWithHamzaAbove, Oe)      // ؤ => ۆ
                   .Replace(ArabicLetterHehDoachashmee, Heh)        // ھ => ه
                   .Replace(ArabicLetterAlefWithHamzaAbove, Alef)   // أ => ا
                   .Replace(ArabicLetterAlefWithMaddaAbove, Alef)   // آ => ا
                   .Replace(ArabicLetterTehMarbuta, Ae)             // ة => ە
                   .Replace(ArabicLetterYeh, Yeh)                   // ي => ی
                   .Replace(ArabicLetterAlefMaksura, Yeh);          // ى => ی

            // Two-character replacements
            builder.Replace($"{Waw}{ArabicFatha}", $"{Oe}");

            // We don't need to account for other types of Yeh, because the are already
            // normalized in the previous step.
            builder.Replace($"{Yeh}{ArabicFatha}", $"{YehWithSmallV}");

            builder.Replace($"{Heh}{ZeroWidthNonJoiner}", $"{Ae}");

            builder.Replace($"{Reh}{ArabicKasra}", $"{RehWithSmallV}");

            builder.Replace($"{Lam}{ArabicFatha}", $"{LamWithSmallV}");

            // Replacements based on rules
            int startOfWord = 0;
            int endOfWord = 0;

            while (endOfWord < builder.Length)
            {
                // Find the start and the end of the next word
                endOfWord = builder.Length - startOfWord <= MaxWordLength ? builder.Length : endOfWord;
                bool reachedEndOfWord = endOfWord == builder.Length;
                while ((endOfWord - startOfWord) < MaxWordLength && endOfWord < builder.Length)
                {
                    switch (builder[endOfWord])
                    {
                        case Space:
                        case FullStop:
                        case SoraniSemicolon:
                        case Semicolon:
                        case SoraniQuestionMark:
                        case LatinQuestionMark:
                            reachedEndOfWord = true;
                            break;
                    }

                    endOfWord++;

                    if (reachedEndOfWord) break;
                }

                // Now apply some transformations based on the characters of the word
                for (int i = startOfWord; i < endOfWord; i++)
                {
                    switch (builder[i])
                    {
                        case Hamza:
                            endOfWord += NormalizeHamza(builder, startOfWord, endOfWord);
                            break;
                        case Alef:
                            endOfWord += NormalizeInitialAlef(builder, startOfWord, endOfWord);
                            break;
                        case Reh:
                            endOfWord += NormalizeInitialReh(builder, startOfWord, endOfWord);
                            break;
                    }
                }

                startOfWord = endOfWord;
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
                
                // A valid hamza has the following properties:
                //  - It's usually at the beginning of the word
                //  - It's never at the end of the word
                //  - It's usually followed by a vowel
                //
                // So If a hamza broke rule 1 as well as one of the other two rules, it's not a hamza,
                // it's acutally meant to be a YehWithSmallV
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

            // In Sorani alphabet words can't start with vowels, so if an alef was at the begining
            // of a word, place a hamza in front of it.
            builder.Insert(0, Hamza);
            return 1;
        }

        private static int NormalizeInitialReh(StringBuilder builder, int startIndex, int limit)
        {
            // Words never start with Reh, if a word started with one, replace it with RehWithSmallV
            if (builder[startIndex] == Reh)
                builder[startIndex] = RehWithSmallV;

            return 0;
        }
        #endregion
    }
}

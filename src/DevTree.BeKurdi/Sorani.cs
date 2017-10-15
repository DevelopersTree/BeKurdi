using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DevTree.BeKurdi.Unicode;

namespace DevTree.BeKurdi
{
    public static class Sorani
    {
        private const int MaxWordLength = 50;

        /// <summary>
        /// Normalizes text to use only standard Sorani unicode characters.
        /// </summary>
        /// <param name="text">The text to normalize</param>
        /// <returns></returns>
        public static string ToStandardSorani(this string text)
        {
            if (text is null) throw new ArgumentNullException(nameof(text));
            if (text.Length == 0) return text;

            var builder = new StringBuilder(text);

            // Simple replacements
            builder.Replace(ArabicTah, SoraniGaf)                   // ط => گ
                   .Replace(ArabicKaf, SoraniKaf)                   // ك => ک
                   .Replace(ArabicDad, SoraniCheem)                 // ض => چ
                   .Replace(ArabicLZah, SoraniVeh)                  // ظ => ڤ
                   .Replace(ArabicTheh, SoraniPeh)                  // ث => پ
                   .Replace(ArabicThal, SoraniJeh)                  // ذ => ژ
                   .Replace(ArabicWawWithHamzaAbove, SoraniOe)      // ؤ => ۆ
                   .Replace(ArabicHehDoachashmee, SoraniHeh)        // ھ => ه
                   .Replace(ArabicAlefWithHamzaAbove, SoraniAlef)   // أ => ا
                   .Replace(ArabicAlefWithMaddaAbove, SoraniAlef)   // آ => ا
                   .Replace(ArabicTehMarbuta, SoraniAe)             // ة => ە
                   .Replace(ArabicYeh, SoraniYeh)                   // ي => ی
                   .Replace(ArabicAlefMaksura, SoraniYeh)           // ى => ی
                   .Replace(LatinComma, SoraniComma)                // ? => ؟
                   .Replace(LatinSemicolon, SoraniSemicolon)        // , => ،
                   .Replace(LatinQuestionMark, SoraniQuestionMark)  // ; => ;
                   .Replace(LatinZero, SoraniZero)                  // 0 => ٠
                   .Replace(LatinOne, SoraniOne)                    // 1 => ١
                   .Replace(LatinTwo, SoraniTwo)                    // 2 => ٢
                   .Replace(LatinThree, SoraniThree)                // 3 => ٣
                   .Replace(LatinFour, SoraniFour)                  // 4 => ٤
                   .Replace(LatinFive, SoraniFive)                  // 5 => ٥
                   .Replace(LatinSix, SoraniSix)                    // 6 => ٦
                   .Replace(LatinSeven, SoraniSeven)                // 7 => ٧
                   .Replace(LatinEight, SoraniEight)                // 8 => ٨
                   .Replace(LatinNine, SoraniNine);                 // 9 => ٩

            // Two-character replacements
            builder.Replace($"{SoraniWaw}{ArabicFatha}", $"{SoraniOe}");

            // We don't need to account for other types of Yeh, because the are already
            // normalized in the previous step.
            builder.Replace($"{SoraniYeh}{ArabicFatha}", $"{SoraniOpenYeh}");

            builder.Replace($"{SoraniHeh}{ZeroWidthNonJoiner}", $"{SoraniAe}");

            builder.Replace($"{SoraniReh}{ArabicKasra}", $"{SoraniHeavyReh}");

            builder.Replace($"{SoraniLam}{ArabicFatha}", $"{SoraniHeavyLam}");

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
                        case LatinSemicolon:
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
                        case SoraniHamza:
                            endOfWord += NormalizeHamza(builder, startOfWord, endOfWord);
                            break;
                        case SoraniAlef:
                            endOfWord += NormalizeInitialAlef(builder, startOfWord, endOfWord);
                            break;
                        case SoraniReh:
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
                if (builder[i] != SoraniHamza)
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
                    builder[i] = SoraniOpenYeh;
                    continue;
                }
            }

            return 0;
        }

        private static int NormalizeInitialAlef(StringBuilder builder, int startIndex, int limit)
        {
            if (limit - startIndex <= 1 || builder[0] != SoraniAlef)
                return 0;

            // In Sorani alphabet words can't start with vowels, so if an alef was at the begining
            // of a word, place a hamza in front of it.
            builder.Insert(0, SoraniHamza);
            return 1;
        }

        private static int NormalizeInitialReh(StringBuilder builder, int startIndex, int limit)
        {
            // Words never start with Reh, if a word started with one, replace it with RehWithSmallV
            if (builder[startIndex] == SoraniReh)
                builder[startIndex] = SoraniHeavyReh;

            return 0;
        }
        #endregion
    }
}

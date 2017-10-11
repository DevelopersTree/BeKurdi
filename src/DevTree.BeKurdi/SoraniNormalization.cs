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

        private static Dictionary<char, Func<StringBuilder, int, int, int>> _transformations = new Dictionary<char, Func<StringBuilder, int, int, int>>
        {
            { ArabicLetterTah,                  (b, s, e) => ReplaceChars(b, s, e, ArabicLetterTah,                 Gaf     ) },
            { ArabicLetterTehMarbuta,           (b, s, e) => ReplaceChars(b, s, e, ArabicLetterTehMarbuta,          Ae      ) },
            { ArabicLetterKaf,                  (b, s, e) => ReplaceChars(b, s, e, ArabicLetterKaf,                 Kaf     ) },
            { ArabicLetterDad,                  (b, s, e) => ReplaceChars(b, s, e, ArabicLetterDad,                 Tcheh   ) },
            { ArabicLetterZah,                  (b, s, e) => ReplaceChars(b, s, e, ArabicLetterZah,                 Veh     ) },
            { ArabicLetterTheh,                 (b, s, e) => ReplaceChars(b, s, e, ArabicLetterTheh,                Peh     ) },
            { ArabicLetterThal,                 (b, s, e) => ReplaceChars(b, s, e, ArabicLetterThal,                Jeh     ) },
            { ArabicLetterWawWithHamzaAbove,    (b, s, e) => ReplaceChars(b, s, e, ArabicLetterWawWithHamzaAbove,   Oe      ) },
            { ArabicLetterHehDoachashmee,       (b, s, e) => ReplaceChars(b, s, e, ArabicLetterHehDoachashmee,      Heh     ) },
            { ArabicLetterAlefWithHamzaAbove,   (b, s, e) => ReplaceChars(b, s, e, ArabicLetterAlefWithHamzaAbove,  Alef    ) },
            { ArabicLetterAlefWithMaddaAbove,   (b, s, e) => ReplaceChars(b, s, e, ArabicLetterAlefWithMaddaAbove,  Alef    ) },

            { Reh,                              NormalizeRe                         },
            { ArabicLetterAlefMaksura,          NormalizeYe                         },
            { ArabicLetterYeh,                  NormalizeYe                         },
            { Yeh,                              NormalizeYe                         },
            { Hamza,                            NormalizeHamza                      },
            { Waw,                              NormalizeWaw                        },
            { ZeroWidthNonJoiner,               NormalizeHehWithZeroWidthNonJoiner  }
        };

        public static string Normalize(this string text)
        {
            var builder = new StringBuilder(text);

            int startIndex = 0;
            int endIndex = 0;

            var symbols = SoraniPunctuation.Union(CommonSymbols).ToList();

            while (endIndex < builder.Length)
            {
                while (endIndex < MaxWordLength && endIndex < builder.Length)
                {
                    if (symbols.Contains(builder[endIndex]))
                    {
                        endIndex++;
                        break;
                    }

                    endIndex++;
                }

                var applicableTransformations = new HashSet<Func<StringBuilder, int, int, int>>();

                for (int i = startIndex; i < endIndex; i++)
                {
                    if (_transformations.ContainsKey(builder[i]))
                    {
                        applicableTransformations.Add(_transformations[builder[i]]);
                    }
                }

                foreach (var transformation in applicableTransformations)
                {
                    endIndex += transformation(builder, startIndex, endIndex);
                }

                startIndex = endIndex;
            }

            return builder.ToString();
        }

        #region Transformation Functions
        private static int NormalizeRe(StringBuilder builder, int startIndex, int limit)
        {
            int change = 0;
            for (int i = startIndex; i < limit; i++)
            {
                if (builder[i] != Reh)
                    continue;

                if (i + 1 < limit && builder[i + 1] == ArabicKasra)
                {
                    builder[i] = RehWithSmallV;
                    builder.Remove(i + 1, 1);
                    change--;
                    limit--;
                    continue;
                }

                if (i == startIndex)
                    builder[startIndex] = RehWithSmallV;
            }

            return change;
        }

        private static int NormalizeYe(StringBuilder builder, int startIndex, int limit)
        {
            return NormalizeLetterThatHasV(builder, startIndex, limit, YehWithSmallV, Yeh, ArabicLetterYeh, ArabicLetterAlefMaksura);
        }

        private static int NormalizeWaw(StringBuilder builder, int startIndex, int limit)
        {
            return NormalizeLetterThatHasV(builder, startIndex, limit, Oe, Waw);
        }

        private static int NormalizeLetterThatHasV(StringBuilder builder, int startIndex, int limit, char replace, char find, params char[] findAlso)
        {
            int change = 0;
            for (int i = startIndex; i < limit; i++)
            {
                if (builder[i] != find && !findAlso.Contains(builder[i]))
                    continue;

                if (i + 1 < limit && builder[i + 1] == ArabicFatha)
                {
                    builder[i] = replace;
                    builder.Remove(i + 1, 1);
                    change--;
                    limit--;
                    continue;
                }

                builder[i] = find;
            }

            return change;
        }

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

        private static int NormalizeHehWithZeroWidthNonJoiner(StringBuilder builder, int startIndex, int limit)
        {
            int change = 0;
            for (int i = startIndex; i < limit; i++)
            {
                if (builder[i] != Heh)
                    continue;

                if (i + 1 < limit && builder[i + 1] == ZeroWidthNonJoiner)
                {
                    builder[i] = Ae;
                    builder.Remove(i + 1, 1);
                    change--;
                    limit--;
                    continue;
                }
            }

            return change;
        }

        private static int ReplaceChars(StringBuilder builder, int startIndex, int endIndex, char find, char replace)
        {
            for (int i = startIndex; i < endIndex; i++)
            {
                if (builder[i] == find)
                {
                    builder[i] = replace;
                }
            }

            return 0;
        }
        #endregion
    }
}

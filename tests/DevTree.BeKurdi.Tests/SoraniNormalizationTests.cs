using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xunit;
using static DevTree.BeKurdi.Unicode;

namespace DevTree.BeKurdi.Tests
{
    public class SoraniNormalizationTests
    {
        [Theory]
        [InlineData(Reh)]                                   // ر => ڕ
        [InlineData(Reh, YehWithSmallV, Waw, Yeh)]          // رێوی => ڕێوی
        public void Normalize_Initial_r_To_R(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized[0] == RehWithSmallV);
        }

        [Theory]
        [InlineData(Jeem, Alef, Reh)]                       // جار
        [InlineData(Seen, Ae, Reh, Dal, Alef, Reh)]         // سەردار
        public void Normalize_Dont_Change_Medial_r_To_R(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized == text);
        }

        [Theory]
        [InlineData(ArabicLetterDad, Tcheh)]                            // ض => چ
        [InlineData(ArabicLetterThal, Jeh)]                             // ذ => ژ
        [InlineData(ArabicLetterZah, Veh)]                              // ظ => ڤ
        [InlineData(ArabicLetterTheh, Peh)]                             // ث => پ
        [InlineData(ArabicLetterTah, Gaf)]                              // ط => گ
        [InlineData(ArabicLetterKaf, Kaf)]                              // ك => ک
        [InlineData(ArabicLetterHehDoachashmee, Heh)]                   // ه‍ => ه 
        [InlineData(ArabicLetterTehMarbuta, Ae)]                        // ة => ە
        [InlineData(ArabicLetterWawWithHamzaAbove, Oe)]                 // ؤ => ۆ
        [InlineData(ArabicLetterAlefMaksura, Yeh)]                      // ى => ی
        [InlineData(ArabicLetterYeh, Yeh)]                              // ي => ی
        [InlineData(ArabicLetterAlefWithHamzaAbove, Alef)]              // أ => ا
        [InlineData(ArabicLetterAlefWithMaddaAbove, Alef)]              // آ => ا
        public void Normalize_Simple_Chars(char find, char replace)
        {
            var text = find.ToString();
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized == replace.ToString());

            text = $"{Alef}{find}";
            AssertSimpleSoraniNormalizer(text, find, replace);

            text = $"{find}{Alef}";
            AssertSimpleSoraniNormalizer(text, find, replace);

            text = $"{Beh}{find}";
            AssertSimpleSoraniNormalizer(text, find, replace);

            text = $"{find}{Beh}";
            AssertSimpleSoraniNormalizer(text, find, replace);
        }

        private void AssertSimpleSoraniNormalizer(string text, char find, char replace)
        {
            var normalized = SoraniNormalization.Normalize(text);
            Assert.True(normalized == text.Replace(find, replace));
        }

        [Theory]
        [InlineData(ArabicLetterYeh, ArabicFatha)]                          // يَ => ێ
        [InlineData(ArabicLetterAlefMaksura, ArabicFatha)]                  // ىَ => ێ
        [InlineData(Beh, ArabicLetterYeh, ArabicFatha)]                     // بيَ => بێ
        [InlineData(RehWithSmallV, ArabicLetterYeh, ArabicFatha, Zain)]     // ڕيَز => ڕێز
        public void Normalize_Ye_With_SmallV(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(YehWithSmallV));
            Assert.False(normalized.Contains(ArabicFatha));
            Assert.False(normalized.Contains(ArabicLetterYeh));
            Assert.False(normalized.Contains(ArabicLetterAlefMaksura));
        }

        [Theory]
        [InlineData(Waw, ArabicFatha)]                                      // وَ => ۆ
        [InlineData(Waw, ArabicFatha)]                                      // ىَ => ۆ
        [InlineData(Beh, Waw, ArabicFatha)]                                 // بوَ => بۆ
        [InlineData(RehWithSmallV, Waw, ArabicFatha, Jeh)]                  // ڕوَژ => ڕۆژ

        [InlineData(ArabicLetterWawWithHamzaAbove)]                         // ؤ => ێ
        [InlineData(Beh, ArabicLetterWawWithHamzaAbove)]                    // بؤ => بۆ
        [InlineData(RehWithSmallV, ArabicLetterWawWithHamzaAbove, Jeh)]     // ڕؤژ => ڕۆژ
        public void Normalize_Oe_With_SmallV(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(Oe));
            Assert.False(normalized.Contains(ArabicFatha));
            Assert.False(normalized.Contains(Waw));
            Assert.False(normalized.Contains(ArabicLetterWawWithHamzaAbove));
        }

        [Theory]
        [InlineData(Reh, ArabicKasra)]                          // رِ => ڕ
        [InlineData(Beh, Reh, ArabicKasra)]                     // برِ => بڕ
        [InlineData(Kaf, Reh, ArabicKasra, Yeh, Noon)]          // کرِین => کڕین
        public void Normalize_Reh_With_SmallV(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(RehWithSmallV));
            Assert.False(normalized.Contains(ArabicKasra));
            Assert.False(normalized.Contains(Reh));
        }

        [Theory]
        [InlineData(Heh, ZeroWidthNonJoiner)]
        [InlineData(Space, Heh, ZeroWidthNonJoiner)]
        [InlineData(Heh, ZeroWidthNonJoiner, Space)]
        [InlineData(Beh, Heh, ZeroWidthNonJoiner)]                  // بە
        [InlineData(Dal, Heh, ZeroWidthNonJoiner, Seen, Teh)]       // دەست
        public void Normalize_Heh_With_Zer_Width_Non_Joiner(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(Ae));
            Assert.False(normalized.Contains(Heh));
            Assert.False(normalized.Contains(ZeroWidthNonJoiner));
        }

        [Theory]
        [InlineData(Hamza, Alef, Seen, Noon)]                       // ئاسان
        [InlineData(Hamza, Ae, Noon, Jeem, Ae, Meem)]               // ئەنجام
        public void Normalize_Hamza_With_Vowels(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(Hamza));
            Assert.False(normalized.Contains(YehWithSmallV));
        }

        [Theory]
        [InlineData(Beh, Hamza)]                                // بئ => بێ
        [InlineData(Beh, Hamza, Gaf, Waw, Meem, Alef, Noon)]    // بئگومان => بێگومان
        public void Normalize_Hamza_With_Consonants(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(YehWithSmallV));
            Assert.False(normalized.Contains(Hamza));
        }

        [Fact] // ئئستا => ئێستا     
        public void Normalize_Hamza_With_Consonants_AtTheBeggining()
        {
            var text = $"{Hamza}{Hamza}{Seen}{Teh}{Alef}"; // ئێستا

            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized[0] == Hamza);
            Assert.True(normalized[1] == YehWithSmallV);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Normalize_A_Very_Long_Text(bool includeSpace)
        {
            var timer = new Stopwatch();
            var random = new Random();

            var space = includeSpace ? new char[] { Space } : new char[] { };
            var ignoredChars = new char[] { ArabicLetterSad, ArabicKasra, ArabicFatha, ZeroWidthNonJoiner };
            var troublesomeChars = NonStandardSoraniAlphabet.Except(ignoredChars);
            var charSet = troublesomeChars.Union(SoraniAlphabet)
                                          .Union(space)
                                          .ToArray();

            var text = new string(Enumerable.Repeat(charSet, 10000)
                                            .Select(set => set[random.Next(charSet.Length)]).ToArray());

            timer.Start();
            var normalized = SoraniNormalization.Normalize(text);
            timer.Stop();

            Assert.True(timer.ElapsedMilliseconds < 1000);
            Assert.False(normalized.Any(c => troublesomeChars.Contains(c)));
        }

    }
}

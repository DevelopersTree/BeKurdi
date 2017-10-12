﻿using System;
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

            Assert.Equal(RehWithSmallV, normalized[0]);
        }

        [Theory]
        [InlineData(Jeem, Alef, Reh)]                       // جار
        [InlineData(Seen, Ae, Reh, Dal, Alef, Reh)]         // سەردار
        public void Normalize_Dont_Change_Medial_r_To_R(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.Equal(text, normalized);
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
            Assert.True(normalized.Contains(replace));
            Assert.False(normalized.Contains(find));
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
        public void Should_Add_Small_V_To_Reh_With_Fatha(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(RehWithSmallV));
            Assert.False(normalized.Contains(ArabicKasra));
            Assert.False(normalized.Contains(Reh));
        }

        [Theory]
        [InlineData(Kaf, Alef, Reh)]                                 // کار
        [InlineData(Teh, Reh, Yeh, Sheen)]                           // تریش
        public void Shouldnt_Add_Small_V_To_Reh_Without_Fatha(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(Reh));
            Assert.False(normalized.Contains(RehWithSmallV));
        }

        [Theory]
        [InlineData(Lam, ArabicFatha)]                          // لَ => ڵ
        [InlineData(Beh, Ae, Lam, ArabicFatha, Alef, Meem)]     // بەلَام => بەڵام
        public void Should_Add_Small_V_To_Lam_With_Fatha(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(LamWithSmallV));
            Assert.False(normalized.Contains(ArabicFatha));
            Assert.False(normalized.Contains(Lam));
        }

        [Theory]
        [InlineData(Lam, Alef, Reh)]                        // لار
        public void Shouldnt_Add_Small_V_To_Lam_Withithout_Fatha(params char[] chars)
        {
            var text = new string(chars);
            var normalized = SoraniNormalization.Normalize(text);

            Assert.True(normalized.Contains(Lam));
            Assert.False(normalized.Contains(LamWithSmallV));
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

            Assert.Equal(Hamza, normalized[0]);
            Assert.Equal(YehWithSmallV, normalized[1]);
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

        [Fact]  // ازاد => ئازاد
        public void Normalize_Aelf_At_The_Begenning_Of_A_Word()
        {
            var text = $"{Alef}{Zain}{Alef}{Dal}";  // ازاد
            var normalized = SoraniNormalization.Normalize(text);

            Assert.Equal(Hamza, normalized[0]);
            Assert.Equal(Alef, normalized[1]);
        }

        [Fact]
        public void Normalize_A_Sentence()
        {
            var text = "ثيَش هةوليَر ضووم بؤ سليَماني. لةويَ ضووم بؤ بازارِ. زؤر شتي جوانم كرِي.";

            var expected = "پێش هەولێر چووم بۆ سلێمانی. لەوێ چووم بۆ بازاڕ. زۆر شتی جوانم کڕی.";

            var normalized = SoraniNormalization.Normalize(text);

            Assert.Equal(expected, normalized);
        }
    }
}

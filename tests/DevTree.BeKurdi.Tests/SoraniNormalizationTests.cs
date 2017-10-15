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
        [Fact]
        public void Should_Return_Empty_String_When_Given_Empty_String()
        {
            var normalized = Sorani.ToStandardSorani(string.Empty);
            Assert.Equal(string.Empty, normalized);
        }

        [Fact]
        public void Passing_Null_Should_Throw_Exception()
        {
            Assert.Throws<ArgumentNullException>(() =>
            Sorani.ToStandardSorani(null));
        }

        [Theory]
        [InlineData(SoraniReh)]                                               // ر => ڕ
        [InlineData(SoraniReh, SoraniOpenYeh, SoraniWaw, SoraniYeh)]          // رێوی => ڕێوی
        public void Should_Change_Initial_r_To_R(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.Equal(SoraniHeavyReh, normalized[0]);
        }

        [Theory]
        [InlineData(SoraniJeem, SoraniAlef, SoraniReh)]                                         // جار
        [InlineData(SoraniSeen, SoraniAe, SoraniReh, SoraniDal, SoraniAlef, SoraniReh)]         // سەردار
        public void Should_Not_Change_Medial_r_To_R(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.Equal(text, normalized);
        }

        [Theory]
        [InlineData(ArabicDad, SoraniCheem)]                            // ض => چ
        [InlineData(ArabicThal, SoraniJeh)]                             // ذ => ژ
        [InlineData(ArabicLZah, SoraniVeh)]                             // ظ => ڤ
        [InlineData(ArabicTheh, SoraniPeh)]                             // ث => پ
        [InlineData(ArabicTah, SoraniGaf)]                              // ط => گ
        [InlineData(ArabicKaf, SoraniKaf)]                              // ك => ک
        [InlineData(ArabicHehDoachashmee, SoraniHeh)]                   // ه‍ => ه 
        [InlineData(ArabicTehMarbuta, SoraniAe)]                        // ة => ە
        [InlineData(ArabicWawWithHamzaAbove, SoraniOe)]                 // ؤ => ۆ
        [InlineData(ArabicAlefMaksura, SoraniYeh)]                      // ى => ی
        [InlineData(ArabicYeh, SoraniYeh)]                              // ي => ی
        [InlineData(ArabicAlefWithHamzaAbove, SoraniAlef)]              // أ => ا
        [InlineData(ArabicAlefWithMaddaAbove, SoraniAlef)]              // آ => ا
        [InlineData(LatinComma, SoraniComma)]                           // ? => ؟
        [InlineData(LatinQuestionMark, SoraniQuestionMark)]             // , => ،
        [InlineData(LatinSemicolon, SoraniSemicolon)]                   // ; => ;
        [InlineData(LatinZero, SoraniZero)]                             // 0 => ٠
        [InlineData(LatinOne, SoraniOne)]                               // 1 => ١
        [InlineData(LatinTwo, SoraniTwo)]                               // 2 => ٢
        [InlineData(LatinThree, SoraniThree)]                           // 3 => ٣
        [InlineData(LatinFour, SoraniFour)]                             // 4 => ٤
        [InlineData(LatinFive, SoraniFive)]                             // 5 => ٥
        [InlineData(LatinSix, SoraniSix)]                               // 6 => ٦
        [InlineData(LatinSeven, SoraniSeven)]                           // 7 => ٧
        [InlineData(LatinEight, SoraniEight)]                           // 8 => ٨
        [InlineData(LatinNine, SoraniNine)]                             // 9 => ٩
        public void Should_Replace_Non_Standard_Char(char find, char replace)
        {
            var text = find.ToString();
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized == replace.ToString());

            text = $"{SoraniAlef}{find}";
            AssertSimpleSoraniNormalizer(text, find, replace);

            text = $"{find}{SoraniAlef}";
            AssertSimpleSoraniNormalizer(text, find, replace);

            text = $"{SoraniBeh}{find}";
            AssertSimpleSoraniNormalizer(text, find, replace);

            text = $"{find}{SoraniBeh}";
            AssertSimpleSoraniNormalizer(text, find, replace);
        }

        private void AssertSimpleSoraniNormalizer(string text, char find, char replace)
        {
            var normalized = Sorani.ToStandardSorani(text);
            Assert.True(normalized.Contains(replace));
            Assert.False(normalized.Contains(find));
        }

        [Theory]
        [InlineData(ArabicYeh, ArabicFatha)]                                // يَ => ێ
        [InlineData(ArabicAlefMaksura, ArabicFatha)]                        // ىَ => ێ
        [InlineData(SoraniBeh, ArabicYeh, ArabicFatha)]                     // بيَ => بێ
        [InlineData(SoraniHeavyReh, ArabicYeh, ArabicFatha, SoraniZeh)]     // ڕيَز => ڕێز
        public void Should_Replace_Yeh_Followed_By_Kasra_To_OpenYeh(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniOpenYeh));
            Assert.False(normalized.Contains(ArabicFatha));
            Assert.False(normalized.Contains(ArabicYeh));
            Assert.False(normalized.Contains(ArabicAlefMaksura));
        }

        [Theory]
        [InlineData(SoraniWaw, ArabicFatha)]                                      // وَ => ۆ
        [InlineData(SoraniWaw, ArabicFatha)]                                      // ىَ => ۆ
        [InlineData(SoraniBeh, SoraniWaw, ArabicFatha)]                           // بوَ => بۆ
        [InlineData(SoraniHeavyReh, SoraniWaw, ArabicFatha, SoraniJeh)]           // ڕوَژ => ڕۆژ

        [InlineData(ArabicWawWithHamzaAbove)]                                     // ؤ => ێ
        [InlineData(SoraniBeh, ArabicWawWithHamzaAbove)]                          // بؤ => بۆ
        [InlineData(SoraniHeavyReh, ArabicWawWithHamzaAbove, SoraniJeh)]          // ڕؤژ => ڕۆژ
        public void Should_Replace_Waw_Followed_By_Fatha_To_Oe(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniOe));
            Assert.False(normalized.Contains(ArabicFatha));
            Assert.False(normalized.Contains(SoraniWaw));
            Assert.False(normalized.Contains(ArabicWawWithHamzaAbove));
        }

        [Theory]
        [InlineData(SoraniReh, ArabicKasra)]                                        // رِ => ڕ
        [InlineData(SoraniBeh, SoraniReh, ArabicKasra)]                             // برِ => بڕ
        [InlineData(SoraniKaf, SoraniReh, ArabicKasra, SoraniYeh, SoraniNoon)]      // کرِین => کڕین
        public void Should_Replace_Reh_Followed_By_Kasra_With_HeavyReh(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniHeavyReh));
            Assert.False(normalized.Contains(ArabicKasra));
            Assert.False(normalized.Contains(SoraniReh));
        }

        [Theory]
        [InlineData(SoraniKaf, SoraniAlef, SoraniReh)]                                 // کار
        [InlineData(SoraniTeh, SoraniReh, SoraniYeh, SoraniSheen)]                     // تریش
        public void Should_Not_Replace_Reh_Not_Followed_By_Kasra(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniReh));
            Assert.False(normalized.Contains(SoraniHeavyReh));
        }

        [Theory]
        [InlineData(SoraniLam, ArabicFatha)]                                                // لَ => ڵ
        [InlineData(SoraniBeh, SoraniAe, SoraniLam, ArabicFatha, SoraniAlef, SoraniMeem)]   // بەلَام => بەڵام
        public void Should_Replace_Lam_Followed_By_Fatha_With_HeavyLam(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniHeavyLam));
            Assert.False(normalized.Contains(ArabicFatha));
            Assert.False(normalized.Contains(SoraniLam));
        }

        [Theory]
        [InlineData(SoraniLam, SoraniAlef, SoraniReh)]                        // لار
        public void Should_Not_Replace_Lam_Not_Followed_By_Fatha(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniLam));
            Assert.False(normalized.Contains(SoraniHeavyLam));
        }

        [Theory]
        [InlineData(SoraniHamza, SoraniAlef, SoraniSeen, SoraniNoon)]                       // ئاسان
        [InlineData(SoraniHamza, SoraniAe, SoraniNoon, SoraniJeem, SoraniAe, SoraniMeem)]   // ئەنجام
        public void Should_Not_Replace_Hamza_Followed_By_Vowels(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniHamza));
            Assert.False(normalized.Contains(SoraniOpenYeh));
        }

        [Theory]
        [InlineData(SoraniBeh, SoraniHamza)]                                                              // بئ => بێ
        [InlineData(SoraniBeh, SoraniHamza, SoraniGaf, SoraniWaw, SoraniMeem, SoraniAlef, SoraniNoon)]    // بئگومان => بێگومان
        public void Should_Replace_Hamza_Followed_By_Consonants_With_OpenYeh(params char[] chars)
        {
            var text = new string(chars);
            var normalized = Sorani.ToStandardSorani(text);

            Assert.True(normalized.Contains(SoraniOpenYeh));
            Assert.False(normalized.Contains(SoraniHamza));
        }

        [Fact] // ئئستا => ئێستا     
        public void Should_Replace_Second_Hamza_But_Not_First_Hamza()
        {
            var text = $"{SoraniHamza}{SoraniHamza}{SoraniSeen}{SoraniTeh}{SoraniAlef}"; // ئێستا

            var normalized = Sorani.ToStandardSorani(text);

            Assert.Equal(SoraniHamza, normalized[0]);
            Assert.Equal(SoraniOpenYeh, normalized[1]);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void Normalize_A_Very_Long_Text(bool includeSpace)
        {
            var timer = new Stopwatch();
            var random = new Random();

            var space = includeSpace ? new char[] { Space } : new char[] { };
            var ignoredChars = new char[] { ArabicSad, ArabicKasra, ArabicFatha, ZeroWidthNonJoiner };
            var troublesomeChars = NonStandardSoraniAlphabet.Except(ignoredChars);
            var charSet = troublesomeChars.Union(SoraniAlphabet)
                                          .Union(space)
                                          .ToArray();

            var text = new string(Enumerable.Repeat(charSet, 10000)
                                            .Select(set => set[random.Next(charSet.Length)]).ToArray());

            timer.Start();
            var normalized = Sorani.ToStandardSorani(text);
            timer.Stop();

            Assert.True(timer.ElapsedMilliseconds < 1000);
            Assert.False(normalized.Any(c => troublesomeChars.Contains(c)));
        }

        [Fact]  // ازاد => ئازاد
        public void Should_Insert_Hamza_To_The_Begenning_Of_The_Words_That_Start_With_Aelf()
        {
            var text = $"{SoraniAlef}{SoraniZeh}{SoraniAlef}{SoraniDal}";  // ازاد
            var normalized = Sorani.ToStandardSorani(text);

            Assert.Equal(SoraniHamza, normalized[0]);
            Assert.Equal(SoraniAlef, normalized[1]);
        }

        [Fact]
        public void Normalize_A_Sentence()
        {
            var text = "ثيَش هةوليَر ضووم بؤ سليَماني. لةويَ ضووم بؤ بازارِ. زؤر شتي جوانم كرِي.";

            var expected = "پێش هەولێر چووم بۆ سلێمانی. لەوێ چووم بۆ بازاڕ. زۆر شتی جوانم کڕی.";

            var normalized = Sorani.ToStandardSorani(text);

            Assert.Equal(expected, normalized);
        }
    }
}

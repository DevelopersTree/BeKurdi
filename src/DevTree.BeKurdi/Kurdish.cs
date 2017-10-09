using System;
using System.Collections.Generic;
using System.Text;

namespace DevTree.BeKurdi
{
    public static class Kurdish
    {

        #region Characters

        #region Standard Sorani
        /// <summary>
        /// <para>Standard Kurdish character: <code>ئ</code> - <code>U+0626</code> </para>
        /// <para>Unicode Name: ARABIC LETTER YEH WITH HAMZA ABOVE </para>
        /// </summary>
        public const char Hamza = '\u0626';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ا</code> - <code>U+0627</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF </para>
        /// </summary>
        public const char Alef = '\u0627';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ب</code> - <code>U+0628</code> </para>
        /// <para>Unicode Name: ARABIC LETTER BEH </para>
        /// </summary>
        public const char Beh = '\u0628';

        /// <summary>
        /// <para>Standard Kurdish character: <code>پ</code> - <code>U+067E</code> </para>
        /// <para>Unicode Name: ARABIC LETTER PEH </para>
        /// </summary>
        public const char Peh = '\u067E';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ت</code> - <code>U+062A</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TEH </para>
        /// </summary>
        public const char Teh = '\u062A';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ج</code> - <code>U+062C</code> </para>
        /// <para>Unicode Name: ARABIC LETTER JEEM </para>
        /// </summary>
        public const char Jeem = '\u062C';

        /// <summary>
        /// <para>Standard Kurdish character: <code>چ</code> - <code>U+0686</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TCHEH </para>
        /// </summary>
        public const char Tcheh = '\u0686';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ح</code> - <code>U+062D</code> </para>
        /// <para>Unicode Name: ARABIC LETTER HAH </para>
        /// </summary>
        public const char Hah = '\u062D';

        /// <summary>
        /// <para>Standard Kurdish character: <code>خ</code> - <code>U+062E</code> </para>
        /// <para>Unicode Name: ARABIC LETTER KHAH </para>
        /// </summary>
        public const char Khah = '\u062E';

        /// <summary>
        /// <para>Standard Kurdish character: <code>د</code> - <code>U+062F</code> </para>
        /// <para>Unicode Name: ARABIC LETTER DAL </para>
        /// </summary>
        public const char Dal = '\u062F';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ر</code> - <code>U+0631</code> </para>
        /// <para>Unicode Name: ARABIC LETTER REH </para>
        /// </summary>
        public const char Reh = '\u0631';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ڕ</code> - <code>U+0695</code> </para>
        /// <para>Unicode Name: ARABIC LETTER REH WITH SMALL V BELOW </para>
        /// </summary>
        public const char RehWithSmallV = '\u0695';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ز</code> - <code>U+0632</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ZAIN </para>
        /// </summary>
        public const char Zain = '\u0632';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ژ</code> - <code>U+0698</code> </para>
        /// <para>Unicode Name: ARABIC LETTER JEH </para>
        /// </summary>
        public const char Jeh = '\u0698';

        /// <summary>
        /// <para>Standard Kurdish character: <code>س</code> - <code>U+0633</code> </para>
        /// <para>Unicode Name: ARABIC LETTER SEEN </para>
        /// </summary>
        public const char Seen = '\u0633';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ش</code> - <code>U+0634</code> </para>
        /// <para>Unicode Name: ARABIC LETTER SHEEN </para>
        /// </summary>
        public const char Sheen = '\u0634';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ع</code> - <code>U+0639</code> </para>
        /// <para>Unicode Name: ARABIC LETTER AIN </para>
        /// </summary>
        public const char Ain = '\u0639';

        /// <summary>
        /// <para>Standard Kurdish character: <code>غ</code> - <code>U+063A</code> </para>
        /// <para>Unicode Name: ARABIC LETTER GHAIN </para>
        /// </summary>
        public const char Ghain = '\u063A';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ف</code> - <code>U+0641</code> </para>
        /// <para>Unicode Name: ARABIC LETTER FEH </para>
        /// </summary>
        public const char Feh = '\u0641';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ڤ</code> - <code>U+06A4</code> </para>
        /// <para>Unicode Name: ARABIC LETTER VEH </para>
        /// </summary>
        public const char Veh = '\u06A4';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ق</code> - <code>U+0642</code> </para>
        /// <para>Unicode Name: ARABIC LETTER QAF </para>
        /// </summary>
        public const char Qaf = '\u0642';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ک</code> - <code>U+06A9</code> </para>
        /// <para>Unicode Name: ARABIC LETTER KEHEH </para>
        /// </summary>
        public const char Kehef = '\u06A9';

        /// <summary>
        /// <para>Standard Kurdish character: <code>گ</code> - <code>U+06AF</code> </para>
        /// <para>Unicode Name: ARABIC LETTER GAF </para>
        /// </summary>
        public const char Gaf = '\u06AF';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ل</code> - <code>U+0644</code> </para>
        /// <para>Unicode Name: ARABIC LETTER LAM </para>
        /// </summary>
        public const char Lam = '\u0644';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ڵ</code> - <code>U+06B5</code> </para>
        /// <para>Unicode Name: ARABIC LETTER LAM WITH SMALL V </para>
        /// </summary>
        public const char LamWithSmallV = '\u06B5';

        /// <summary>
        /// <para>Standard Kurdish character: <code>م</code> - <code>U+0645</code> </para>
        /// <para>Unicode Name: ARABIC LETTER MEEM </para>
        /// </summary>
        public const char Meem = '\u0645';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ن</code> - <code>U+0646</code> </para>
        /// <para>Unicode Name: ARABIC LETTER NOON </para>
        /// </summary>
        public const char Noon = '\u0646';

        /// <summary>
        /// <para>Standard Kurdish character: <code>و</code> - <code>U+0648</code> </para>
        /// <para>Unicode Name: ARABIC LETTER WAW </para>
        /// </summary>
        public const char Waw = '\u0648';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ۆ</code> - <code>U+06C6</code> </para>
        /// <para>Unicode Name: ARABIC LETTER OE </para>
        /// </summary>
        public const char Oe = '\u06C6';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ه، هـ</code> - <code>U+0647</code> </para>
        /// <para>Unicode Name: ARABIC LETTER HEH </para>
        /// </summary>
        public const char Heh = '\u0647';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ە، ـە</code> - <code>U+06D5</code> </para>
        /// <para>Unicode Name: ARABIC LETTER AE </para>
        /// </summary>
        public const char Ae = '\u06D5';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ی</code> - <code>U+06CC</code> </para>
        /// <para>Unicode Name: ARABIC LETTER FARSI YEH </para>
        /// </summary>
        public const char Yeh = '\u06CC';

        /// <summary>
        /// <para>Standard Kurdish character: <code>ێ</code> - <code>U+06CE</code> </para>
        /// <para>Unicode Name: ARABIC LETTER YEH WITH SMALL V </para>
        /// </summary>
        public const char YehWithSmallV = '\u06CE';
        #endregion

        #region Non-Standard Sorani

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>َ</code> - <code>U+064E</code> </para>
        /// <para>Unicode Name: ARABIC FATHA </para>
        /// </summary>
        public const char ArabicFatha = '\u064E';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>أ</code> - <code>U+0623</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF WITH HAMZA ABOVE </para>
        /// </summary>
        public const char ArabicLetterAlefWithHamzaAbove = '\u0623';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>آ</code> - <code>U+0622</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF WITH MADDA ABOVE </para>
        /// </summary>
        public const char ArabicLetterAlefWithMaddaAbove = '\u0622';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ض</code> - <code>U+0636</code> </para>
        /// <para>Unicode Name: ARABIC LETTER DAD </para>
        /// </summary>
        public const char ArabicLetterDad = '\u0636';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ث</code> - <code>U+062B</code> </para>
        /// <para>Unicode Name: ARABIC LETTER THEH </para>
        /// </summary>
        public const char ArabicLetterTheh = '\u062B';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ظ</code> - <code>U+0638</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ZAH </para>
        /// </summary>
        public const char ArabicLetterZah = '\u0638';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ً</code> - <code>U+064B</code> </para>
        /// <para>Unicode Name: ARABIC FATHATAN </para>
        /// </summary>
        public const char ArabicFathatan = '\u064B';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ي</code> - <code>U+064A</code> </para>
        /// <para>Unicode Name: ARABIC LETTER YEH </para>
        /// </summary>
        public const char ArabicLetterYeh = '\u064A';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ى</code> - <code>U+0649</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF MAKSURA </para>
        /// </summary>
        public const char ArabicLetterAlefMaksura = '\u0649';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ِ</code> - <code>U+0650</code> </para>
        /// <para>Unicode Name: ARABIC KASRA </para>
        /// </summary>
        public const char ArabicKasra = '\u0650';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ؤ</code> - <code>U+0624</code> </para>
        /// <para>Unicode Name: ARABIC LETTER WAW WITH HAMZA ABOVE </para>
        /// </summary>
        public const char ArabicLetterWawWithHamzaAbove = '\u0624';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ذ</code> - <code>U+0630</code> </para>
        /// <para>Unicode Name: ARABIC LETTER THAL </para>
        /// </summary>
        public const char ArabicLetterThal = '\u0630';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ك</code> - <code>U+0643</code> </para>
        /// <para>Unicode Name: ARABIC LETTER KAF </para>
        /// </summary>
        public const char ArabicLetterKaf = '\u0643';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ھ</code> - <code>U+06BE</code> </para>
        /// <para>Unicode Name: ARABIC LETTER HEH DOACHASHMEE </para>
        /// </summary>
        public const char ArabicLetterHehDoachashmee = '\u06BE';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>‌</code> - <code>U+200C</code> </para>
        /// <para>Unicode Name: ZERO WIDTH NON-JOINER </para>
        /// </summary>
        public const char ZeroWidthNonJoiner = '\u200C';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ة</code> - <code>U+0629</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TEH MARBUTA </para>
        /// </summary>
        public const char ArabicLetterTehMarbuta = '\u0629';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ص</code> - <code>U+0635</code> </para>
        /// <para>Unicode Name: ARABIC LETTER SAD </para>
        /// </summary>
        public const char ArabicLetterSad = '\u0635';

        /// <summary>
        /// <para>Non-Standard Kurdish character: <code>ط</code> - <code>U+0635</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TAH </para>
        /// </summary>
        public const char ArabicLetterTah = '\u0637';

        #endregion

        /// <summary>
        /// <para>Standard Kurdish character: <code> </code> - <code>U+0020</code> </para>
        /// <para>Unicode Name: SPACE </para>
        /// </summary>
        public const char Space = '\u0020';

        #endregion

        #region Character Sets
        /// <summary>
        /// List of standard unicode characters for Kurdish language when written in Sorani alphabet as accepted by the Kurdish Academy.
        /// More Information: http://unicode.ekrg.org/ku_unicodes.html
        /// </summary>
        public static IReadOnlyList<char> StandardUnicodeSoraniAlphabet => new List<char>
        {
            Hamza,  Alef,   Beh,    Peh,    Teh,    Jeem,   Tcheh,  Hah,    Khah,   Dal,    Reh,    RehWithSmallV,
            Zain,   Jeh,    Seen,   Sheen,  Ain,    Ghain,  Feh,    Veh,    Qaf,    Kehef,  Gaf,    Lam,
            Meem,   Noon,   Waw,    Oe,     Ae,     Heh,    Yeh,    YehWithSmallV
        };

        /// <summary>
        /// List of non-standard unicode characters sometimes used to write Kurdish in Sorani alphabet.
        /// </summary>
        public static IReadOnlyList<char> NonStandardSoraniAlphabet => new List<char>
        {
            ArabicFatha,        ArabicLetterAlefWithHamzaAbove,     ArabicLetterAlefWithMaddaAbove,     ArabicFathatan,
            ArabicLetterDad,    ArabicLetterTheh,                   ArabicLetterTah,                    ArabicLetterYeh,   
            ArabicKasra,        ArabicLetterWawWithHamzaAbove,      ArabicLetterHehDoachashmee,         ArabicLetterAlefMaksura,
            ArabicLetterThal,   ZeroWidthNonJoiner,                 ArabicLetterTehMarbuta,             ArabicLetterSad,
            ArabicLetterKaf
        };
        #endregion
    }
}

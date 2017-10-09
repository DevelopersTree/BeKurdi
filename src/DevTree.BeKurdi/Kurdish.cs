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
        /// <para>Standard Sorani letter: <code>ئ</code> - <code>U+0626</code> </para>
        /// <para>Unicode Name: ARABIC LETTER YEH WITH HAMZA ABOVE </para>
        /// </summary>
        public const char Hamza = '\u0626';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ا</code> - <code>U+0627</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF </para>
        /// </summary>
        public const char Alef = '\u0627';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ب</code> - <code>U+0628</code> </para>
        /// <para>Unicode Name: ARABIC LETTER BEH </para>
        /// </summary>
        public const char Beh = '\u0628';

        /// <summary>
        /// <para>Standard Sorani letter: <code>پ</code> - <code>U+067E</code> </para>
        /// <para>Unicode Name: ARABIC LETTER PEH </para>
        /// </summary>
        public const char Peh = '\u067E';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ت</code> - <code>U+062A</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TEH </para>
        /// </summary>
        public const char Teh = '\u062A';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ج</code> - <code>U+062C</code> </para>
        /// <para>Unicode Name: ARABIC LETTER JEEM </para>
        /// </summary>
        public const char Jeem = '\u062C';

        /// <summary>
        /// <para>Standard Sorani letter: <code>چ</code> - <code>U+0686</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TCHEH </para>
        /// </summary>
        public const char Tcheh = '\u0686';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ح</code> - <code>U+062D</code> </para>
        /// <para>Unicode Name: ARABIC LETTER HAH </para>
        /// </summary>
        public const char Hah = '\u062D';

        /// <summary>
        /// <para>Standard Sorani letter: <code>خ</code> - <code>U+062E</code> </para>
        /// <para>Unicode Name: ARABIC LETTER KHAH </para>
        /// </summary>
        public const char Khah = '\u062E';

        /// <summary>
        /// <para>Standard Sorani letter: <code>د</code> - <code>U+062F</code> </para>
        /// <para>Unicode Name: ARABIC LETTER DAL </para>
        /// </summary>
        public const char Dal = '\u062F';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ر</code> - <code>U+0631</code> </para>
        /// <para>Unicode Name: ARABIC LETTER REH </para>
        /// </summary>
        public const char Reh = '\u0631';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ڕ</code> - <code>U+0695</code> </para>
        /// <para>Unicode Name: ARABIC LETTER REH WITH SMALL V BELOW </para>
        /// </summary>
        public const char RehWithSmallV = '\u0695';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ز</code> - <code>U+0632</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ZAIN </para>
        /// </summary>
        public const char Zain = '\u0632';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ژ</code> - <code>U+0698</code> </para>
        /// <para>Unicode Name: ARABIC LETTER JEH </para>
        /// </summary>
        public const char Jeh = '\u0698';

        /// <summary>
        /// <para>Standard Sorani letter: <code>س</code> - <code>U+0633</code> </para>
        /// <para>Unicode Name: ARABIC LETTER SEEN </para>
        /// </summary>
        public const char Seen = '\u0633';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ش</code> - <code>U+0634</code> </para>
        /// <para>Unicode Name: ARABIC LETTER SHEEN </para>
        /// </summary>
        public const char Sheen = '\u0634';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ع</code> - <code>U+0639</code> </para>
        /// <para>Unicode Name: ARABIC LETTER AIN </para>
        /// </summary>
        public const char Ain = '\u0639';

        /// <summary>
        /// <para>Standard Sorani letter: <code>غ</code> - <code>U+063A</code> </para>
        /// <para>Unicode Name: ARABIC LETTER GHAIN </para>
        /// </summary>
        public const char Ghain = '\u063A';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ف</code> - <code>U+0641</code> </para>
        /// <para>Unicode Name: ARABIC LETTER FEH </para>
        /// </summary>
        public const char Feh = '\u0641';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ڤ</code> - <code>U+06A4</code> </para>
        /// <para>Unicode Name: ARABIC LETTER VEH </para>
        /// </summary>
        public const char Veh = '\u06A4';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ق</code> - <code>U+0642</code> </para>
        /// <para>Unicode Name: ARABIC LETTER QAF </para>
        /// </summary>
        public const char Qaf = '\u0642';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ک</code> - <code>U+06A9</code> </para>
        /// <para>Unicode Name: ARABIC LETTER KEHEH </para>
        /// </summary>
        public const char Kehef = '\u06A9';

        /// <summary>
        /// <para>Standard Sorani letter: <code>گ</code> - <code>U+06AF</code> </para>
        /// <para>Unicode Name: ARABIC LETTER GAF </para>
        /// </summary>
        public const char Gaf = '\u06AF';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ل</code> - <code>U+0644</code> </para>
        /// <para>Unicode Name: ARABIC LETTER LAM </para>
        /// </summary>
        public const char Lam = '\u0644';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ڵ</code> - <code>U+06B5</code> </para>
        /// <para>Unicode Name: ARABIC LETTER LAM WITH SMALL V </para>
        /// </summary>
        public const char LamWithSmallV = '\u06B5';

        /// <summary>
        /// <para>Standard Sorani letter: <code>م</code> - <code>U+0645</code> </para>
        /// <para>Unicode Name: ARABIC LETTER MEEM </para>
        /// </summary>
        public const char Meem = '\u0645';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ن</code> - <code>U+0646</code> </para>
        /// <para>Unicode Name: ARABIC LETTER NOON </para>
        /// </summary>
        public const char Noon = '\u0646';

        /// <summary>
        /// <para>Standard Sorani letter: <code>و</code> - <code>U+0648</code> </para>
        /// <para>Unicode Name: ARABIC LETTER WAW </para>
        /// </summary>
        public const char Waw = '\u0648';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ۆ</code> - <code>U+06C6</code> </para>
        /// <para>Unicode Name: ARABIC LETTER OE </para>
        /// </summary>
        public const char Oe = '\u06C6';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ه، هـ</code> - <code>U+0647</code> </para>
        /// <para>Unicode Name: ARABIC LETTER HEH </para>
        /// </summary>
        public const char Heh = '\u0647';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ە، ـە</code> - <code>U+06D5</code> </para>
        /// <para>Unicode Name: ARABIC LETTER AE </para>
        /// </summary>
        public const char Ae = '\u06D5';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ی</code> - <code>U+06CC</code> </para>
        /// <para>Unicode Name: ARABIC LETTER FARSI YEH </para>
        /// </summary>
        public const char Yeh = '\u06CC';

        /// <summary>
        /// <para>Standard Sorani letter: <code>ێ</code> - <code>U+06CE</code> </para>
        /// <para>Unicode Name: ARABIC LETTER YEH WITH SMALL V </para>
        /// </summary>
        public const char YehWithSmallV = '\u06CE';
        #endregion // Standard Sorani

        #region Sorani Numbers
        /// <summary>
        /// <para>Sorani Number: <code>٠</code> - <code>U+0660</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT ZERO </para>
        /// </summary>
        public const char SoraniZero = '\u0660';

        /// <summary>
        /// <para>Sorani Number: <code>١</code> - <code>U+0661</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT ONE </para>
        /// </summary>
        public const char SoraniOne = '\u0661';

        /// <summary>
        /// <para>Sorani Number: <code>٢</code> - <code>U+0662</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT TWO </para>
        /// </summary>
        public const char SoraniTwo = '\u0662';

        /// <summary>
        /// <para>Sorani Number: <code>٣</code> - <code>U+0663</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT THREE </para>
        /// </summary>
        public const char SoraniThree = '\u0663';

        /// <summary>
        /// <para>Sorani Number: <code>٤</code> - <code>U+0664</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT FOUR </para>
        /// </summary>
        public const char SoraniFour = '\u0664';

        /// <summary>
        /// <para>Sorani Number: <code>٥</code> - <code>U+0665</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT FIVE </para>
        /// </summary>
        public const char SoraniFive = '\u0665';

        /// <summary>
        /// <para>Sorani Number: <code>٦</code> - <code>U+0666</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT SIX </para>
        /// </summary>
        public const char SoraniSix = '\u0666';

        /// <summary>
        /// <para>Sorani Number: <code>٧</code> - <code>U+0667</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT SEVEN </para>
        /// </summary>
        public const char SoraniSeven = '\u0667';

        /// <summary>
        /// <para>Sorani Number: <code>٨</code> - <code>U+0668</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT EIGHT </para>
        /// </summary>
        public const char SoraniEight = '\u0668';

        /// <summary>
        /// <para>Sorani Number: <code>٩</code> - <code>U+0669</code> </para>
        /// <para>Unicode Name: ARABIC-INDIC DIGIT NINE </para>
        /// </summary>
        public const char SoraniNine = '\u0669';
        #endregion

        #region Sorani Punctuation
        /// <summary>
        /// <para>Sorani punctuation: <code>،</code> - <code>U+060C</code> </para>
        /// <para>Unicode Name: ARABIC COMMA </para>
        /// </summary>
        public const char SoraniComma = '\u060C';

        /// <summary>
        /// <para>Sorani punctuation: <code>ـ</code> - <code>U+0640</code> </para>
        /// <para>Unicode Name: ARABIC TATWEEL </para>
        /// </summary>
        public const char SoraniDash = '\u0640';

        /// <summary>
        /// <para>Sorani punctuation: <code>»</code> - <code>U+00BB</code> </para>
        /// <para>Unicode Name: RIGHT-POINTING DOUBLE ANGLE QUOTATION MARK </para>
        /// </summary>
        public const char SoraniRightQuotationMark = '\u00BB';

        /// <summary>
        /// <para>Sorani punctuation: <code>«</code> - <code>U+00AB</code> </para>
        /// <para>Unicode Name: LEFT-POINTING DOUBLE ANGLE QUOTATION MARK </para>
        /// </summary>
        public const char SoraniLeftQuotationMark = '\u00AB';

        /// <summary>
        /// <para>Sorani punctuation: <code>؟</code> - <code>U+061F</code> </para>
        /// <para>Unicode Name: ARABIC QUESTION MARK </para>
        /// </summary>
        public const char SoraniQuestionMark = '\u061F';

        /// <summary>
        /// <para>Sorani punctuation: <code>؛</code> - <code>U+061B</code> </para>
        /// <para>Unicode Name: ARABIC SEMICOLON </para>
        /// </summary>
        public const char SoraniSemicolon = '\u061B';
        #endregion // Sorani unctuation

        #region Non-Standard Sorani
        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>َ</code> - <code>U+064E</code> </para>
        /// <para>Unicode Name: ARABIC FATHA </para>
        /// </summary>
        public const char ArabicFatha = '\u064E';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>أ</code> - <code>U+0623</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF WITH HAMZA ABOVE </para>
        /// </summary>
        public const char ArabicLetterAlefWithHamzaAbove = '\u0623';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>آ</code> - <code>U+0622</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF WITH MADDA ABOVE </para>
        /// </summary>
        public const char ArabicLetterAlefWithMaddaAbove = '\u0622';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ض</code> - <code>U+0636</code> </para>
        /// <para>Unicode Name: ARABIC LETTER DAD </para>
        /// </summary>
        public const char ArabicLetterDad = '\u0636';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ث</code> - <code>U+062B</code> </para>
        /// <para>Unicode Name: ARABIC LETTER THEH </para>
        /// </summary>
        public const char ArabicLetterTheh = '\u062B';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ظ</code> - <code>U+0638</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ZAH </para>
        /// </summary>
        public const char ArabicLetterZah = '\u0638';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ً</code> - <code>U+064B</code> </para>
        /// <para>Unicode Name: ARABIC FATHATAN </para>
        /// </summary>
        public const char ArabicFathatan = '\u064B';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ي</code> - <code>U+064A</code> </para>
        /// <para>Unicode Name: ARABIC LETTER YEH </para>
        /// </summary>
        public const char ArabicLetterYeh = '\u064A';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ى</code> - <code>U+0649</code> </para>
        /// <para>Unicode Name: ARABIC LETTER ALEF MAKSURA </para>
        /// </summary>
        public const char ArabicLetterAlefMaksura = '\u0649';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ِ</code> - <code>U+0650</code> </para>
        /// <para>Unicode Name: ARABIC KASRA </para>
        /// </summary>
        public const char ArabicKasra = '\u0650';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ؤ</code> - <code>U+0624</code> </para>
        /// <para>Unicode Name: ARABIC LETTER WAW WITH HAMZA ABOVE </para>
        /// </summary>
        public const char ArabicLetterWawWithHamzaAbove = '\u0624';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ذ</code> - <code>U+0630</code> </para>
        /// <para>Unicode Name: ARABIC LETTER THAL </para>
        /// </summary>
        public const char ArabicLetterThal = '\u0630';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ك</code> - <code>U+0643</code> </para>
        /// <para>Unicode Name: ARABIC LETTER KAF </para>
        /// </summary>
        public const char ArabicLetterKaf = '\u0643';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ھ</code> - <code>U+06BE</code> </para>
        /// <para>Unicode Name: ARABIC LETTER HEH DOACHASHMEE </para>
        /// </summary>
        public const char ArabicLetterHehDoachashmee = '\u06BE';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>‌</code> - <code>U+200C</code> </para>
        /// <para>Unicode Name: ZERO WIDTH NON-JOINER </para>
        /// </summary>
        public const char ZeroWidthNonJoiner = '\u200C';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ة</code> - <code>U+0629</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TEH MARBUTA </para>
        /// </summary>
        public const char ArabicLetterTehMarbuta = '\u0629';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ص</code> - <code>U+0635</code> </para>
        /// <para>Unicode Name: ARABIC LETTER SAD </para>
        /// </summary>
        public const char ArabicLetterSad = '\u0635';

        /// <summary>
        /// <para>Non-Standard Sorani letter: <code>ط</code> - <code>U+0635</code> </para>
        /// <para>Unicode Name: ARABIC LETTER TAH </para>
        /// </summary>
        public const char ArabicLetterTah = '\u0637';
        #endregion // Non-Standard Sorani

        #region Common Symbols
        /// <summary>
        /// <para>Common symbol: <code>.</code> - <code>U+002E</code> </para>
        /// <para>Unicode Name: FULL STOP </para>
        /// </summary>
        public const char FullStop = '\u002E';

        /// <summary>
        /// <para>Common symbol: <code>:</code> - <code>U+003A</code> </para>
        /// <para>Unicode Name: COLON </para>
        /// </summary>
        public const char Colon = '\u003A';

        /// <summary>
        /// <para>Common symbol: <code>(</code> - <code>U+0028</code> </para>
        /// <para>Unicode Name: LEFT PARENTHESIS </para>
        /// </summary>
        public const char LeftParenthesis = '\u0028';

        /// <summary>
        /// <para>Common symbol: <code>)</code> - <code>U+0029</code> </para>
        /// <para>Unicode Name: RIGHT PARENTHESIS </para>
        /// </summary>
        public const char RightParenthesis = '\u0029';

        /// <summary>
        /// <para>Common symbol: <code>!</code> - <code>U+0021</code> </para>
        /// <para>Unicode Name: EXCLAMATION MARK </para>
        /// </summary>
        public const char ExclamationMark = '\u0021';

        /// <summary>
        /// <para>Common symbol: <code>/</code> - <code>U+002F</code> </para>
        /// <para>Unicode Name: SOLIDUS </para>
        /// </summary>
        public const char Slash = '\u002F';

        /// <summary>
        /// <para>Common symbol: <code>\</code> - <code>U+005C</code> </para>
        /// <para>Unicode Name: REVERSE SOLIDUS </para>
        /// </summary>
        public const char BackSlash = '\u005C';

        /// <summary>
        /// <para>Common symbol: <code>,</code> - <code>U+002C</code> </para>
        /// <para>Unicode Name: COMMA </para>
        /// </summary>
        public const char Comma = '\u002C';

        /// <summary>
        /// <para>Common symbol: <code>-</code> - <code>U+002D</code> </para>
        /// <para>Unicode Name: HYPHEN-MINUS </para>
        /// </summary>
        public const char Hyphen = '\u002D';

        /// <summary>
        /// <para>Standard Kurdish character: <code> </code> - <code>U+0020</code> </para>
        /// <para>Unicode Name: SPACE </para>
        /// </summary>
        public const char Space = '\u0020';

        /// <summary>
        /// <para>Common Symbols: <code>^</code> - <code>U+005E</code> </para>
        /// <para>Unicode Name: CIRCUMFLEX ACCENT </para>
        /// </summary>
        public const char CircumflexAccent = '\u005E';

        /// <summary>
        /// <para>Common Symbols: <code>%</code> - <code>U+0025</code> </para>
        /// <para>Unicode Name: PERCENT SIGN </para>
        /// </summary>
        public const char PercentSign = '\u0025';

        /// <summary>
        /// <para>Common Symbols: <code>$</code> - <code>U+0024</code> </para>
        /// <para>Unicode Name: DOLLAR SIGN </para>
        /// </summary>
        public const char DollarSign = '\u0024';

        /// <summary>
        /// <para>Common Symbols: <code>#</code> - <code>U+0023</code> </para>
        /// <para>Unicode Name: NUMBER SIGN </para>
        /// </summary>
        public const char NumberSign = '\u0023';

        /// <summary>
        /// <para>Common Symbols: <code>@</code> - <code>U+0040</code> </para>
        /// <para>Unicode Name: COMMERCIAL AT </para>
        /// </summary>
        public const char CommercialAt = '\u0040';

        /// <summary>
        /// <para>Common Symbols: <code>&</code> - <code>U+0026</code> </para>
        /// <para>Unicode Name: AMPERSAND </para>
        /// </summary>
        public const char Ampersand = '\u0026';

        /// <summary>
        /// <para>Common Symbols: <code>*</code> - <code>U+002A</code> </para>
        /// <para>Unicode Name: ASTERISK </para>
        /// </summary>
        public const char Asterisk = '\u002A';

        /// <summary>
        /// <para>Common Symbols: <code>_</code> - <code>U+005F</code> </para>
        /// <para>Unicode Name: LOW LINE </para>
        /// </summary>
        public const char LowLine = '\u005F';

        /// <summary>
        /// <para>Common Symbols: <code>+</code> - <code>U+002B</code> </para>
        /// <para>Unicode Name: PLUS SIGN </para>
        /// </summary>
        public const char PlusSign = '\u002B';

        /// <summary>
        /// <para>Common Symbols: <code>[</code> - <code>U+005B</code> </para>
        /// <para>Unicode Name: LEFT SQUARE BRACKET </para>
        /// </summary>
        public const char LeftSquareBracket = '\u005B';

        /// <summary>
        /// <para>Common Symbols: <code>]</code> - <code>U+005D</code> </para>
        /// <para>Unicode Name: RIGHT SQUARE BRACKET </para>
        /// </summary>
        public const char RightSquareBracket = '\u005D';

        /// <summary>
        /// <para>Common Symbols: <code>}</code> - <code>U+007D</code> </para>
        /// <para>Unicode Name: RIGHT CURLY BRACKET </para>
        /// </summary>
        public const char RightCurlyBracket = '\u007D';

        /// <summary>
        /// <para>Common Symbols: <code>{</code> - <code>U+007B</code> </para>
        /// <para>Unicode Name: LEFT CURLY BRACKET </para>
        /// </summary>
        public const char LeftCurlyBracket = '\u007B';

        /// <summary>
        /// <para>Common Symbols: <code>’</code> - <code>U+2019</code> </para>
        /// <para>Unicode Name: RIGHT SINGLE QUOTATION MARK </para>
        /// </summary>
        public const char RightSingleQuotationMark = '\u2019';

        /// <summary>
        /// <para>Common Symbols: <code>‘</code> - <code>U+2018</code> </para>
        /// <para>Unicode Name: LEFT SINGLE QUOTATION MARK </para>
        /// </summary>
        public const char LeftSingleQuotationMark = '\u2018';

        /// <summary>
        /// <para>Common Symbols: <code>~</code> - <code>U+007E</code> </para>
        /// <para>Unicode Name: TILDE </para>
        /// </summary>
        public const char Tilde = '\u007E';

        /// <summary>
        /// <para>Common Symbols: <code>|</code> - <code>U+007C</code> </para>
        /// <para>Unicode Name: VERTICAL LINE </para>
        /// </summary>
        public const char VerticalLine = '\u007C';

        /// <summary>
        /// <para>Common Symbols: <code>=</code> - <code>U+003D</code> </para>
        /// <para>Unicode Name: EQUALS SIGN </para>
        /// </summary>
        public const char EqualsSign = '\u003D';

        /// <summary>
        /// <para>Common Symbols: <code>;</code> - <code>U+003B</code> </para>
        /// <para>Unicode Name: SEMICOLON </para>
        /// </summary>
        public const char Semicolon = '\u003B';

        /// <summary>
        /// <para>Common Symbols: <code><</code> - <code>U+003C</code> </para>
        /// <para>Unicode Name: LESS-THAN SIGN </para>
        /// </summary>
        public const char LessThanSign = '\u003C';

        /// <summary>
        /// <para>Common Symbols: <code>></code> - <code>U+003E</code> </para>
        /// <para>Unicode Name: GREATER-THAN SIGN </para>
        /// </summary>
        public const char GreaterThanSign = '\u003E';

        /// <summary>
        /// <para>Common Symbols: <code>§</code> - <code>U+00A7</code> </para>
        /// <para>Unicode Name: SECTION SIGN </para>
        /// </summary>
        public const char SectionSign = '\u00A7';

        /// <summary>
        /// <para>Common Symbols: <code>¨</code> - <code>U+00A8</code> </para>
        /// <para>Unicode Name: DIAERESIS </para>
        /// </summary>
        public const char Diaeresis = '\u00A8';

        /// <summary>
        /// <para>Common Symbols: <code>©</code> - <code>U+00A9</code> </para>
        /// <para>Unicode Name: COPYRIGHT SIGN </para>
        /// </summary>
        public const char CopyrightSign = '\u00A9';

        /// <summary>
        /// <para>Common Symbols: <code>`</code> - <code>U+0060</code> </para>
        /// <para>Unicode Name: GRAVE ACCENT </para>
        /// </summary>
        public const char GraveAccent = '\u0060';

        /// <summary>
        /// <para>Common Symbols: <code>®</code> - <code>U+00AE</code> </para>
        /// <para>Unicode Name: REGISTERED SIGN </para>
        /// </summary>
        public const char RegisteredSign = '\u00AE';

        /// <summary>
        /// <para>Common Symbols: <code>°</code> - <code>U+00B0</code> </para>
        /// <para>Unicode Name: DEGREE SIGN </para>
        /// </summary>
        public const char DegreeSign = '\u00B0';

        /// <summary>
        /// <para>Common Symbols: <code>·</code> - <code>U+00B7</code> </para>
        /// <para>Unicode Name: MIDDLE DOT </para>
        /// </summary>
        public const char MiddleDot = '\u00B7';

        /// <summary>
        /// <para>Common Symbols: <code>´</code> - <code>U+00B4</code> </para>
        /// <para>Unicode Name: ACUTE ACCENT </para>
        /// </summary>
        public const char AcuteAccent = '\u00B4';
        #endregion // Common Symbols

        #region Latin Numbers
        /// <summary>
        /// <para>Latin Number: <code>0</code> - <code>U+0030</code> </para>
        /// <para>Unicode Name: DIGIT ZERO </para>
        /// </summary>
        public const char LatinZero = '\u0030';

        /// <summary>
        /// <para>Latin Number: <code>1</code> - <code>U+0031</code> </para>
        /// <para>Unicode Name: DIGIT ONE </para>
        /// </summary>
        public const char LatinOne = '\u0031';

        /// <summary>
        /// <para>Latin Number: <code>2</code> - <code>U+0032</code> </para>
        /// <para>Unicode Name: DIGIT TWO </para>
        /// </summary>
        public const char LatinTwo = '\u0032';

        /// <summary>
        /// <para>Latin Number: <code>3</code> - <code>U+0033</code> </para>
        /// <para>Unicode Name: DIGIT THREE </para>
        /// </summary>
        public const char LatinThree = '\u0033';

        /// <summary>
        /// <para>Latin Number: <code>4</code> - <code>U+0034</code> </para>
        /// <para>Unicode Name: DIGIT FOUR </para>
        /// </summary>
        public const char LatinFour = '\u0034';

        /// <summary>
        /// <para>Latin Number: <code>5</code> - <code>U+0035</code> </para>
        /// <para>Unicode Name: DIGIT FIVE </para>
        /// </summary>
        public const char LatinFive = '\u0035';

        /// <summary>
        /// <para>Latin Number: <code>6</code> - <code>U+0036</code> </para>
        /// <para>Unicode Name: DIGIT SIX </para>
        /// </summary>
        public const char LatinSix = '\u0036';

        /// <summary>
        /// <para>Latin Number: <code>7</code> - <code>U+0037</code> </para>
        /// <para>Unicode Name: DIGIT SEVEN </para>
        /// </summary>
        public const char LatinSeven = '\u0037';

        /// <summary>
        /// <para>Latin Number: <code>8</code> - <code>U+0038</code> </para>
        /// <para>Unicode Name: DIGIT EIGHT </para>
        /// </summary>
        public const char LatinEight = '\u0038';

        /// <summary>
        /// <para>Latin Number: <code>9</code> - <code>U+0039</code> </para>
        /// <para>Unicode Name: DIGIT NINE </para>
        /// </summary>
        public const char LatinNine = '\u0039';
        #endregion // Latin Numbers
        #endregion // Characters

        #region Character Sets
        /// <summary>
        /// Gets the list of standard unicode characters for Kurdish language when written in Sorani alphabet as accepted by the Kurdish Academy.
        /// More Information: http://unicode.ekrg.org/ku_unicodes.html
        /// </summary>
        public static IReadOnlyList<char> SoraniAlphabet => new List<char>
        {
            Hamza,  Alef,   Beh,    Peh,    Teh,    Jeem,   Tcheh,  Hah,    Khah,   Dal,    Reh,    RehWithSmallV,
            Zain,   Jeh,    Seen,   Sheen,  Ain,    Ghain,  Feh,    Veh,    Qaf,    Kehef,  Gaf,    Lam,
            LamWithSmallV, Meem,   Noon,   Waw,    Oe,     Ae,     Heh,    Yeh,    YehWithSmallV
        };

        /// <summary>
        /// Gets the list of numbers used in standard Sorani alphabet.
        /// More Information: http://unicode.ekrg.org/ku_unicodes.html
        /// </summary>
        public static IReadOnlyList<char> SoraniNumbers => new List<char>
        {
            SoraniZero, SoraniOne, SoraniTwo,   SoraniThree, SoraniFour,
            SoraniFive, SoraniSix, SoraniSeven, SoraniEight, SoraniNine
        };

        /// <summary>
        /// Gets the list of punctuation characters used in the standard Sorani alphabet.
        /// </summary>
        public static IReadOnlyList<char> SoraniPunctuation => new List<char>
        {
            FullStop, Colon, SoraniComma, SoraniDash, RightParenthesis, LeftParenthesis, SoraniRightQuotationMark, SoraniLeftQuotationMark,
            ExclamationMark, SoraniQuestionMark, SoraniSemicolon, Slash, BackSlash, Comma, Hyphen, Space
        };

        /// <summary>
        /// Gets the list of symbols that exist in multiple alphabets.
        /// </summary>
        public static IReadOnlyList<char> CommonSymbols => new List<char>
        {
            CircumflexAccent, PercentSign, DollarSign, NumberSign, CommercialAt, Ampersand, Asterisk, RightParenthesis,
            LeftParenthesis, LowLine, PlusSign, RightSquareBracket, LeftSquareBracket, RightCurlyBracket, LeftCurlyBracket,
            LeftSingleQuotationMark, RightSingleQuotationMark, Tilde, VerticalLine, EqualsSign, Comma, Semicolon,
            GreaterThanSign, LessThanSign, SectionSign, Diaeresis, CopyrightSign, RegisteredSign, DegreeSign, MiddleDot, AcuteAccent
        };

        /// <summary>
        /// Gets the list of non-standard unicode characters sometimes used to write Kurdish in Sorani alphabet.
        /// </summary>
        public static IReadOnlyList<char> NonStandardSoraniAlphabet => new List<char>
        {
            ArabicFatha,        ArabicLetterAlefWithHamzaAbove,     ArabicLetterAlefWithMaddaAbove,     ArabicFathatan,
            ArabicLetterDad,    ArabicLetterTheh,                   ArabicLetterTah,                    ArabicLetterYeh,
            ArabicKasra,        ArabicLetterWawWithHamzaAbove,      ArabicLetterHehDoachashmee,         ArabicLetterAlefMaksura,
            ArabicLetterThal,   ZeroWidthNonJoiner,                 ArabicLetterTehMarbuta,             ArabicLetterSad,
            ArabicLetterKaf
        };

        /// <summary>
        /// Gets the list of numbers used in the Latin alphabet.
        /// </summary>
        public static IReadOnlyList<char> LatinNumbers => new List<char>
        {
            LatinZero, LatinOne, LatinTwo,   LatinThree, LatinFour,
            LatinFive, LatinSix, LatinSeven, LatinEight, LatinNine
        };
        #endregion // Character Sets
    }
}

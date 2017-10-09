using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace DevTree.BeKurdi.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteCodeForCharacterSet(@"D:\Common.txt", Kurdish.CommonSymbols);
        }

        public static void WriteCodeForCharacterSet(string fileName, IReadOnlyList<char> characterSet)
        {
            var unicodeData = File.ReadAllLines("UnicodeData.txt").Select(l =>
            {
                var parts = l.Split(';');

                return new { Code = parts[0], Name = parts[1] };
            }).ToDictionary(c => c.Code);

            var builder = new StringBuilder();
            foreach (var character in characterSet)
            {
                var characterCode = ((int)character).ToString("X4");
                var unicodeCharacter = unicodeData[characterCode];

                builder.Append($@"
        /// <summary>
        /// <para>Common Symbols: <code>{character}</code> - <code>U+{characterCode}</code> </para>
        /// <para>Unicode Name: {unicodeCharacter.Name} </para>
        /// </summary>
        public const char {ProcessName(unicodeCharacter.Name)} = '\u{characterCode}';
");
            }

            File.WriteAllText(fileName, builder.ToString());
        }

        private static TextInfo textInfo = new CultureInfo("en-US").TextInfo;
        private static string ProcessName(string UnicodeName)
        {
            return textInfo.ToTitleCase(UnicodeName.ToLower()).Replace(" ", "");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Creating String...");
            var text = @"ئةوديوى رووداوةكان لةخةلك دةشارنةوة و جاوبةستى زؤر خةلكيان كردووة (لةلايةك ئيتفاقى زيَرةوةو لة سةرةوةش كوردايةتى فرؤشتنةوة بة خةلكى بئ ئاكا لة سياسةت) ئةكينا برواناكةم هيندة لةوة جاكتر هةبئ سةربةخؤبين بةلام بة راستةقينة نةك دوو فاقى";

            Console.WriteLine($"String Created... {text.Length:n0} Characters.. {Encoding.UTF8.GetByteCount(text):n0} bytes");
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var normalized = SoraniNormalization.Normalize(text);
            stopWatch.Stop();
            Console.WriteLine($"Elapsed: {stopWatch.ElapsedMilliseconds:n0}");
            Console.WriteLine(normalized);
            File.WriteAllText(@"D:\test.txt", normalized);

            Console.ReadKey();
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

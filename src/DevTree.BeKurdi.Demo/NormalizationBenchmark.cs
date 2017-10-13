using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Attributes.Jobs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DevTree.BeKurdi.Demo
{
    public class NormalizationBenchmark
    {
        public string Text100M { get; }
        public string Text10M { get; }
        public string Text1M { get; }
        public NormalizationBenchmark()
        {
            var random = new Random();
            var charSet = Unicode.NonStandardSoraniAlphabet.Union(Unicode.SoraniAlphabet)
                                                          .Union(new char[] { Unicode.Space })
                                                          .ToArray();

            Text10M = new string(Enumerable.Repeat(charSet, 10_000_000)
                                            .Select(set => set[random.Next(charSet.Length)]).ToArray());
            Text1M = Text10M.Substring(0, 1_000_000);
        }

        //[Benchmark]
        //public string Normalize100M()
        //{
        //    return SoraniNormalization.Normalize(Text100M);
        //}

        [Benchmark]
        public string Normalize10M()
        {
            return Sorani.Normalize(Text10M);
        }

        [Benchmark]
        public string Normalize1M()
        {
            return Sorani.Normalize(Text1M);
        }

        public string RegexReplace()
        {
            string text = "";
            for (int i = 0; i < 20; i++)
            {
                text = Regex.Replace(Text100M, $"({Unicode.Heh}{Unicode.ZeroWidthNonJoiner})", $"{Unicode.Ae}", RegexOptions.IgnoreCase);
            }

            return text;
        }

        public string StringReplaceBrackets()
        {
            string text = Text100M;
            for (int i = 0; i < 20; i++)
            {
                text = text.Replace($"({Unicode.Heh}{Unicode.ZeroWidthNonJoiner})", $"{Unicode.Ae}");
            }

            return text;
        }

        public string StringReplace()
        {
            string text = Text100M;
            for (int i = 0; i < 20; i++)
            {
                text = text.Replace($"{Unicode.Heh}{Unicode.ZeroWidthNonJoiner}", $"{Unicode.Ae}");
            }

            return text;
        }

        public string StringReplaceEnglish()
        {
            string text = Text100M;
            for (int i = 0; i < 20; i++)
            {
                text = text.Replace($"A", $"{Unicode.Ae}");
            }

            return text;
        }
    }
}

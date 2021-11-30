using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace SearchForAnagram.Benchmark
{
    [MemoryDiagnoser]
    public class SearchAnagram
    {
        [Params("лесопромышленность", "телекс")]
        public string wordOne;
        [Params("солепромышленность", "скелет")]
        public string wordTwo;

        [Benchmark(Baseline = true)]
        public bool SortCharArraySequenceEqual()
        {
            return SortedCharFromString(wordOne)
                .SequenceEqual(SortedCharFromString(wordTwo));
        }
        
        [Benchmark]
        public bool DictionaryAllContainsAndEquals()
        {
            var dictionaryOne = DictionaryFromString(wordOne);
            var dictionaryTwo = DictionaryFromString(wordTwo);
            return dictionaryOne.Keys
                .All(k => dictionaryTwo.ContainsKey(k) && dictionaryTwo[k] == dictionaryOne[k]);
        }

        private char[] SortedCharFromString(string word)
        {
            var charArray = word.ToCharArray();
            Array.Sort(charArray);
            return charArray;
        }
        
        private Dictionary<char, int> DictionaryFromString(string word)
        {
            return word.GroupBy(c => c)
                .ToDictionary(x => x.Key, x=> x.Count());
        }


    }
}
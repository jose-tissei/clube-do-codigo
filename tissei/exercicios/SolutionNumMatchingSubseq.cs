using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionNumMatchingSubseq
    {
        public int NumMatchingSubseq(string s, string[] words)
        {
            var map = new Dictionary<char, List<int>>();
            for (var i = 0; i < s.Length; i++)
            {
                if (map.TryGetValue(s[i], out var list))
                {
                    list.Add(i);
                }
                else
                {
                    map[s[i]] = new List<int>() { i };
                }
            }

            var validSubSeqs = 0;
            //abcde => bb
            //=> 
            foreach (var word in words)
            {  
                var index = -1;
                var isValidSubSeq = true;
                foreach (var chr in word)
                {
                    if (!map.TryGetValue(chr, out var list))
                    {
                        isValidSubSeq = false;
                        break;
                    }

                    isValidSubSeq = false;
                    var searchResult = list.BinarySearch(index + 1);
                    var pos = ~searchResult;

                    if(pos > list.Count - 1) break;

                    if (searchResult < 0)
                    {
                        index = list[~searchResult++];
                    }
                    else
                    {
                        index++;
                    }

                    isValidSubSeq = true;
                }
                if (isValidSubSeq) validSubSeqs++;
            }

            return validSubSeqs;
        }

        //public int NumMatchingSubseq(string s, string[] words)
        //{
        //    var map = new Dictionary<char, List<int>>();
        //    for (var i = 0; i < s.Length; i++)
        //    {
        //        if (map.TryGetValue(s[i], out var list))
        //        {
        //            list.Add(i);
        //        }
        //        else
        //        {
        //            map[s[i]] = new List<int>() { i };
        //        }
        //    }

        //    var validSubSeqs = 0;

        //    foreach (var word in words)
        //    {
        //        var index = -1;
        //        var isValidSubSeq = true;
        //        for (var i = 0; i < word.Length; i++)
        //        {
        //            if (!map.ContainsKey(word[i]))
        //            {
        //                isValidSubSeq = false;
        //                break;
        //            }

        //            isValidSubSeq = false;
        //            foreach (var si in map[word[i]])
        //            {
        //                if (si > index)
        //                {
        //                    index = si;
        //                    isValidSubSeq = true;
        //                    break;
        //                }
        //            }

        //            if (!isValidSubSeq)
        //            {
        //                break;
        //            }
        //        }
        //        if (isValidSubSeq) validSubSeqs++;
        //    }

        //    return validSubSeqs;
        //}

        //public int NumMatchingSubseq(string s, string[] words)
        //{
        //    var matcher = s.GroupBy(chr => chr).ToDictionary(k => k.Key, v => v.Count());
        //    var counter = 0;
        //    foreach (var word in words)
        //    {
        //        bool isSubSeq = true;
        //        var dict = new Dictionary<char, int>();
        //        foreach (var chr in word)
        //        {
        //            if (!matcher.ContainsKey(chr))
        //            {
        //                isSubSeq = false;
        //                break;
        //            }

        //            if (dict.TryGetValue(chr, out var count))
        //            {
        //                count++;

        //                if (matcher[chr] < count)
        //                {
        //                    isSubSeq = false;
        //                    break;
        //                }

        //                dict[chr] = count;
        //            }
        //            else
        //            {
        //                dict[chr] = 1;
        //            }

        //        }

        //        if (isSubSeq) counter++;
        //    }

        //    return counter;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionGroupAnagrams
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var dict = new Dictionary<int, List<string>>();

            foreach (var word in strs)
            {
                var key = 1;
                foreach (var chr in word)
                {
                    key = key * (chr + 2);
                }

                if (dict.TryGetValue(key, out List<string>? value))
                {
                    value.Add(word);
                }
                else
                {
                    dict[key] = new List<string>() { word };
                }
            }

            return dict.Select(x => x.Value).ToList();
        }

        //PQP FIQUEI 1 HORA FAZENDO ESSSA GAMBI SENDO QUE ERA SO EU MULTIPLICAAAAA
        //public List<List<string>> GroupAnagrams(string[] strs)
        //{
        //    var dics = new Dictionary<string, Dictionary<char, int>>();
        //    var input = strs.ToList();

        //    foreach (var word in input)
        //    {
        //        var wordDict = new Dictionary<char, int>();

        //        foreach (var chr in word)
        //        {
        //            if (wordDict.TryGetValue(chr, out int count))
        //            {
        //                wordDict[chr] = count++;
        //            }
        //            else
        //            {
        //                wordDict[chr] = 1;
        //            }
        //        }

        //        dics[word] = wordDict;
        //    }

        //    var result = new List<List<string>>();

        //    foreach (var word in input.ToArray()) {
        //    //for (var i = 0; i <= strs.Length; i++)
        //    //{
        //    //    var word = strs[i];
        //        var matches = new List<string>() { word };
        //        foreach (var match in input.ToArray().Skip(1)) 
        //        {
        //        //for (var j = i+1; j <= strs.Length; j++)
        //        //{
        //        //    var match = strs[j];
        //            var equals = false;

        //            if (word == match) equals = true;

        //            if (dics[word].Keys.Count != dics[match].Keys.Count) continue;

        //            foreach (var chr in dics[word].Keys)
        //            {
        //                if(!dics[match].TryGetValue(chr, out int count))
        //                {
        //                    equals = false;
        //                    break;
        //                }

        //                if (dics[word][chr] == count) equals = true;
        //            }

        //            if(equals)
        //            {
        //                matches.Add(match);
        //                input.Remove(match);
        //            } else
        //            {

        //            }
        //        }

        //        result.Add(matches);
        //        input.Remove(word);
        //    }

        //    return result;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionEncodeDecode
    {
        private const char WordSeparator = ';';
        private const char CharSeparator = ',';

        public string Encode(IList<string> strs)
        {
            if (strs.Count == 0) return null;

            if (strs.Count == 1 && string.IsNullOrEmpty(strs.First())) return strs.First();

            var result = new StringBuilder();
            foreach (string str in strs) 
            {
                foreach (char str2 in str) 
                {
                    result.Append((int)str2);
                    result.Append(CharSeparator);
                }
                result.Append(WordSeparator);
            }

            return result.ToString();
        }

        public List<string> Decode(string s)
        {
            if (s is null) return new List<string>();
            if (s == "") return new List<string>() {s};

            return s.Split(WordSeparator).SkipLast(1).Select(Join).ToList();

        }

        private string Join(string s) => string.Join("", s.TrimEnd().Split(CharSeparator).SkipLast(1).Select(c => (char)Convert.ToInt32(c)));
    }
}

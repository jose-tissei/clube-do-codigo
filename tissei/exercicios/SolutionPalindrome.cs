using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionPalindrome
    {
        public bool IsPalindrome(string s)
        {
            var i = 0;
            var j = s.Length - 1;

            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i])) i++;
                while (j > i && !char.IsLetterOrDigit(s[j])) j--;

                if (char.ToUpperInvariant(s[i]) != char.ToUpperInvariant(s[j])) return false;

                i++;
                j--;
            }
            return true;
        }
    }
}

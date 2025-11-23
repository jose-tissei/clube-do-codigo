using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionMergeTriplets
    {
        public bool MergeTriplets(int[][] triplets, int[] target)
        {
            var good = new bool[3];
            for (var i = 0; i < triplets.Length; i++)
            {
                bool tooBig = false;
                var matchList = new bool[3];
                for (var j = 0; j < 3; j++)
                {
                    if (triplets[i][j] == target[j])
                    {
                        matchList[j] = true;
                    }
                    else if (triplets[i][j] > target[j])
                    {
                        tooBig = true;
                    }

                    if (tooBig) break;
                }

                if (tooBig) continue;

                for (var mi = 0; mi < 3; mi++)
                {
                    if (matchList[mi])
                    {
                        good[mi] = true;
                    }
                }

                if (good.ToList().All(x => x)) return true;
            }

            return false;
        }
    }

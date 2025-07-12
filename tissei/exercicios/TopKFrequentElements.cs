using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class TopKFrequentElements
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            var dict = new Dictionary<int, int>();

            for(int i = 0; i < nums.Length; i++) 
            { 
                var num = nums[i];
                if(dict.TryGetValue(num, out int value))
                {
                    dict[num] = value + 1;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            return dict.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToArray();
        }
    }

}

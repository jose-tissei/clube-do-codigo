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
            var buckets = new List<int>[nums.Length + 1];

            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (dict.TryGetValue(num, out int value))
                {
                    dict[num] = value + 1;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (var item in dict)
            {
                if (buckets[item.Value] is null) buckets[item.Value] = new List<int>();
                buckets[item.Value].Add(item.Key);
            }

            var result = new int[k];
            var index = 0;

            for (int j = nums.Length; j > 0 && index < k; j--)
            {
                if (buckets[j] is null) continue;

                foreach (var item in buckets[j])
                {
                    result[index++] = item;
                    if (index == k) return result;
                }
            }

            return result;
        }
    }

}

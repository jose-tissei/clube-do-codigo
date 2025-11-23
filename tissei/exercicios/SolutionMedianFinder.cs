using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionMedianFinder
    {

        private SortedList<double, double> list = new SortedList<double, double>();

        public SolutionMedianFinder()
        {

        }

        public void AddNum(int num)
        {
            list.Add(num + (list.Count / 100.0), num + (list.Count/100.0));
        }

        public double FindMedian()
        {
            var middle = (int)Math.Floor((list.Count-1) / 2.0);
            if (list.Count % 2 == 0)
            {
                return Math.Floor((double)list.Values[middle] + list.Values[middle + 1]) / 2.0;
            }
            else
            {
                return (double)list.Values[middle];
            }
        }
    }
}

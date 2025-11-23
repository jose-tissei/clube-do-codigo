using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    public class SolutionNQueens
    {
        private HashSet<int> Columns = new HashSet<int>();
        private HashSet<int> PosDiag = new HashSet<int>();
        private HashSet<int> NegDiag = new HashSet<int>();
        private List<string> Result;
        private List<List<string>> Result2 = new List<List<string>>();
        private int N;

        public List<List<string>> SolveNQueens(int n)
        {
            N = n;
            Result = Enumerable.Range(0, n).Select(_ => new string('.', n)).ToList();
            var j =0;

            while (j <= N)
            {
                var succQuens = 0;
                Backtrack(0, j, ref succQuens);

                if (succQuens == N) 
                {
                    Result2.Add(Result);
                }

                Columns = new HashSet<int>();
                PosDiag = new HashSet<int>();
                NegDiag = new HashSet<int>();
                Result = Enumerable.Range(0, n).Select(_ => new string('.', n)).ToList();
                j++;
            }

            return Result2;
        }

        private void Backtrack(int i, int j, ref int succQuens)
        {
            if (i >= N || j >= N) return;

            if (Columns.Contains(j) || NegDiag.Contains(i - j) || PosDiag.Contains(i + j))
            {

                if (j + 1 >= N) Backtrack(++i, 0, ref succQuens);
                else Backtrack(i, ++j, ref succQuens);
            }
            else
            {
                Result[i].Remove(j, 1).Insert(j, "Q");
                Columns.Add(j);
                PosDiag.Add(i + j);
                NegDiag.Add(i - j);
                succQuens++;
                Backtrack(++i, 0, ref succQuens);
            }
        }

        public List<List<string>> SolveNQueens2(int n)
        {
            var result = new List<List<string>>();

            for (var bfi = 0; bfi < n; bfi++)
            {
                for (var bfj = 0; bfj < n; bfj++)
                {
                    char[,] matrix = new char[n, n];
                    matrix[bfi, bfj] = 'Q';
                    var queens = new List<(int i, int j)>() { (i: bfi, j: bfj) };
                    for (var i = 0; i < n; i++)
                    {
                        for (var j = 0; j < n; j++)
                        {
                            var canPosition = true;
                            foreach (var queen in queens)
                            {
                                if (queen.i == i || queen.j == j)
                                {
                                    canPosition = false;
                                    break;
                                }

                                var absDiffI = queen.i - i;
                                var absDiffJ = queen.j - j;

                                if (absDiffI == absDiffJ && absDiffI != 0)
                                {
                                    canPosition = false;
                                    break;
                                } 

                            }

                            if (queens.Count <= n && canPosition)

                            {
                                matrix[i, j] = 'Q';
                                queens.Add((i, j));
                            }
                        }
                    }

                    if (queens.Count != n) break;

                    var resultList = new List<string>();
                    for (var row = 0; row < n; row++)
                    {
                        var sb = new StringBuilder();
                        for (var col = 0; col < n; col++)
                        {
                            sb.Append(matrix[row, col] == 'Q' ? 'Q' : '.');
                        }
                        resultList.Add(sb.ToString());
                    }

                    result.Add(resultList);
                }
            }

            return result;
        }
    }
}

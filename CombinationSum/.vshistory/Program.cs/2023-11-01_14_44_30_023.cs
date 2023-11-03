﻿using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> nums = new() {};
            _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, new(), ref nums);
            foreach (var item in nums)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("break");
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static void _CombinationSum(int[] candidates, int target, List<int> finalResult, ref List<List<int>> Result)
        {
            if (target < 0)
            {
                return;
            }
            if (target == 0)
            {
                Result.Add(finalResult);
                return;
            }
            foreach (var candidate in candidates)
            {
                finalResult.Add(candidate);
                _CombinationSum(candidates, target - candidate, finalResult, ref Result);
                var _candidate = candidates.ToList();
                _candidate.RemoveAt(candidates.Length - 1);

            }

        }
    }
}
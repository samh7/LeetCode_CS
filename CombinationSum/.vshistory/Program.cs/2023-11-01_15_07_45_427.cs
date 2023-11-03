﻿using System.Collections;

namespace CombinationSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = _CombinationSum(new int[] { 2, 3, 6, 7 }, 7, 0);
            foreach (var t in result)
            {
                Console.WriteLine(t);
            }
        }
        public static IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            return new List<IList<int>>();
        }
        private static void _CombinationSum(int[] candidates, int target, List<int> temp, int index)
        {
            if (target == 0)
            {
                return;
            }
            if (target < 0)
            {
                return;
            }
            var finalResult = new List<int>();
            for (int i = index; i < candidates.Length; i++)
            {
                temp.Add(candidates[i]);
                _CombinationSum(candidates, target - candidates[i], temp, index);
                temp.Remove(candidates[i]);
            }
            //return finalResult;
        }
    }
}
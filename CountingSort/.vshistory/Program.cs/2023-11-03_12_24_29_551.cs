﻿namespace CountingSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>()
            {
                2,5,1,0
            };
            CountingSort(nums);

        }

        public static List<int> CountingSort(List<int> nums)
        {
            var largestNum = nums.Max(i => i);
            var smallestNum = nums.Min(i => i);
            var positionOfNums = new int[largestNum];
            for (int i = 0; i < largestNum; i++)
            {

            }
            foreach (var item in nums)
            {
                positionOfNums[item]++;
            }
            for (int i = 1; i < largestNums; i++)
            {
                positionOfNums[i] += positionOfNums[i - 1];
            }
            foreach (var item in positionOfNums)
            {
                Console.WriteLine(item);
            }
            return null;
        }
    }
}
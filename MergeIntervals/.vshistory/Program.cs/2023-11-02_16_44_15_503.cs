﻿using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = Merge(Merge(new int[][]
             {


                new int[] {0,1 },
                 new int[] {1 , 5},
                //new int[] {15,18},
             }));
            foreach (var item in t)
            {
                foreach (var item1 in item)
                {
                    Console.WriteLine(item1);
                }
                Console.WriteLine("break");
            }
        }

        public static int[][] Merge(int[][] intervals)
        {
            var intervalsList = intervals.ToList();
            return intervalsList.ToArray();
        }

        public static int[][] SortIntervals(int[][] intervals)
        {
            var intervalsDict = new Dictionary<int, int>();
            int[] keys = new int[intervals.Length];
            for (int i = 0; i < intervals.Length; i++)
            {
                keys[i] = intervals[i][0];
                intervalsDict.Add(intervals[i][0], intervals[i][1]);
            }
            Array.Sort(keys);
            for (int i = 0; i < intervals.Length; i++)
            {
                intervalsDict.TryGetValue(i, out intervals[i][0]);
            }
            return null;
        }
    }
}
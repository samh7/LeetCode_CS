﻿using System.Collections.Immutable;

namespace MergeIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[][]
             {

                new int[] {0,1 },
                 new int[] {1 , 5},
                new int[] {15,18},
                                new int[] {11,18},
                                                new int[] {2,18},
                                                new int[] {3,18},
                                                new int[] {4,18},
                                                new int[] {9,18},
                                                new int[] {10,18},
                                                                new int[] {17,18},
             };
            var t = Merge(Merge(nums));


            Console.WriteLine(nums.Length);
            foreach (var item in t)
            {
                //foreach (var item1 in item)
                //{
                //    Console.WriteLine(item1);
                //}
                //Console.WriteLine("break");
            }
        }

        public static int[][] Merge(int[][] intervals)
        {
            return SortIntervals(intervals);

        }

        public static dynamic SortIntervals(int[][] intervals)
        {
            var intervalsDict = new Dictionary<int, int>();
            List<int> keys = new List<int>();
            for (int i = 0; i < intervals.Length; i++)
            {
                if (intervalsDict.ContainsKey(intervals[i][0]))
                {
                    var valueAtI = intervalsDict[intervals[i][0]];
                    if (valueAtI < intervals[i][1])
                    {
                        intervalsDict[intervals[i][0]] = intervals[i][1];
                    }
                    continue;
                }
                keys.Add(intervals[i][0]);
                intervalsDict.Add(intervals[i][0], intervals[i][1]);
            }

            keys.Sort();
            var intervalsList = new List<int[]>();
            for (int i = 0; i < keys.Count; i++)
            {
                int val;
                var isAdded = intervalsDict.TryGetValue(keys[i], out val);
                if (isAdded)
                {
                    intervalsList[i][0] = keys[i];
                }
                keys.RemoveAt(i);
            }
            return intervals;
        }
    }
}

﻿namespace MinOperationsToMakeAlternating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static int MinOperations(string s)
        {
            int count = 0;
            var sList = s.ToList();
            for (int i = 0; i < sList.Count - 1; i++)
            {
                if (sList[i] == sList[i + 1])
                {
                    sList[i] = (sList[i] == '1') ? '0' : '1';
                    count++;
                }
            }
            return count;
        }
    }
}
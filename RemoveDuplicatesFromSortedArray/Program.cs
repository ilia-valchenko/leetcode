using System;
using System.Collections.Generic;

namespace RemoveDuplicatesFromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new []
            {
                (new[] { 1, 1, 2 }, 2),
                (new[] { 0,0,1,1,1,2,2,3,3,4 }, 5)
            };

            foreach (var item in input)
            {
                var result = RemoveDuplicates(item.Item1);
                var expectedResult = item.Item2;

                if (expectedResult != result)
                {
                    Console.WriteLine($"FAILED. RemoveDuplicates returned {result} instead of {expectedResult}. Input: [{ToString(item.Item1)}].");
                    Console.WriteLine("Tap to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine($"PASSED. Result: {result}. Array: [{ToString(item.Item1)}].");
                }
            }

            Console.WriteLine("All tests are passed.");
            Console.WriteLine("Tap to continue...");
            Console.ReadKey();
        }

        public static int RemoveDuplicates(int[] nums)
        {
            var result = nums.Length;
            var index = 0;
            var current = nums[index];

            var list = new List<int>()
            {
                current
            };

            if (nums.Length == 1)
            {
                return nums.Length;
            }

            for (int i = 1; i < nums.Length; i++)
            {
                if (current == nums[i])
                {
                    result--;
                }
                else
                {
                    current = nums[i];
                    list.Add(nums[i]);
                }
            }

            var arr = list.ToArray();

            #region It's a small hack which helped me to resolve a weird leetcode issue. The following construction didn't work: nums = list.ToArray();
            for (var i = 0; i < arr.Length; i++)
            {
                nums[i] = arr[i];
            } 
            #endregion

            return result;
        }

        private static string ToString<T>(T[] arr) {
            return string.Join(",", arr);
        }
    }
}

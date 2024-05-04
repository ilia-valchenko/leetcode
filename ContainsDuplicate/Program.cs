using System;
using System.Collections.Generic;

namespace ContainsDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            var testItems = new[]
            {
                new TestItem
                {
                    InputArray = new [] { 1,2,3,1 },
                    Result = true
                },
                new TestItem
                {
                    InputArray = new [] { 1,2,3,4 },
                    Result = false
                },
                new TestItem
                {
                    InputArray = new [] { 1,1,1,3,3,4,3,2,4,2 },
                    Result = true
                }
            };

            foreach (var testItem in testItems)
            {
                var actualResult = ContainsDuplicate(testItem.InputArray);

                if (actualResult != testItem.Result)
                {
                    Console.WriteLine($"\n\nFAILED. Expected: {testItem.Result}. Actual: {actualResult}. Input array: [{ToString(testItem.InputArray)}].");
                }
            }

            Console.WriteLine("Tap to continue...");
            Console.ReadKey();
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            if (nums.Length == 1)
            {
                return false;
            }

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.TryAdd(nums[i], nums[i]))
                {
                    return true;
                }
            }

            return false;
        }

        private static string ToString<T>(T[] array)
        {
            return string.Join(",", array);
        }
    }
}

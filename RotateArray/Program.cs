using System;

namespace RotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var testItems = new[]
            {
                new TestItem
                {
                    OriginalArray = new[] {1,2,3,4,5,6,7},
                    ShiftValue = 3,
                    ExpectedResultArray = new[] {5,6,7,1,2,3,4}
                },
                new TestItem
                {
                    OriginalArray = new[] {-1,-100,3,99},
                    ShiftValue = 2,
                    ExpectedResultArray = new[] {3,99,-1,-100}
                }
            };

            foreach (var testItem in testItems)
            {
                Rotate(testItem.OriginalArray, testItem.ShiftValue);
                var isValid = true;

                for (var i = 0; i < testItem.OriginalArray.Length; i++)
                {
                    if (testItem.OriginalArray[i] != testItem.ExpectedResultArray[i])
                    {
                        isValid = false;

                        Console.WriteLine("\n\nThe array was rotated in a wrong way. " +
                            $"\nRotated array: [{ToString(testItem.OriginalArray)}]. " +
                            $"\nExpected result: [{ToString(testItem.ExpectedResultArray)}].");

                        break;
                    }
                }
            }

            Console.WriteLine("Tap to continue...");
            Console.ReadKey();
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return;
            }

            var cloneArray = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                cloneArray[i] = nums[i];
            }

            for (int i = 0; i < cloneArray.Length; i++)
            {
                var newIndex = i + k < nums.Length ? i + k : (i + k) % nums.Length;
                nums[newIndex] = cloneArray[i];
            }
        }

        private static string ToString<T>(T[] array)
        {
            return string.Join(",", array);
        }
    }
}

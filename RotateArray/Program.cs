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

            Console.WriteLine("All tests are passed.");
            Console.WriteLine("Tap to continue...");
            Console.ReadKey();
        }

        public static void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
            {
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                var helper = nums[i];
                var newIndex = i + k <= nums.Length ? i + k : 
                nums[i] = nums[]
            }
        }
    }
}

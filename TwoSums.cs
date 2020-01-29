using System;

namespace Leet_Code
{
    class TwoSums
    {
        static void Main(string[] args)
        {
            int[] testarray = { 2, 8, 6, 1, 5, 15, 17, 19, 30, 11, 7, 4 };
            Console.WriteLine(String.Join(" ", Sum(testarray,14)));
        }
        static int[] Sum(int[] nums, int target)
        {
           
            for(int i = 0; i < nums.Length -1 ; i++)
            {
                    for (int b = i + 1; b < nums.Length ; b++)
                    {
                        if (nums[i] + nums[b] == target)
                        { 
                            int[] solution = { 1, b };
                            return solution;
                        }
                    }
            }
            return null;
        }
    }
}

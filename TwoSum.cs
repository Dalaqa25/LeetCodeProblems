using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodesProblems
{
    public class Solution
    {
        static int[] TwoSum(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right];

                if (sum == target)
                {
                    return new int[] { left, right };
                }
                else if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return null;
        }


        static public void Main(String[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int target = 9;

            int[] result = TwoSum(nums, target);

            if (result != null)
            {
                Console.WriteLine("indecses " + result[0] + ", " + result[1]);
            }
            else
            {
                Console.WriteLine("NotFound!");
            }
        }
        
    }
}

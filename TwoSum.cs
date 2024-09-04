using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        // hashSet
        HashSet<int> set = new HashSet<int>();
        
        // loop
        for (int i = 0; i < nums.Length; i++)
        {
            int complemant = target - nums[i];

            if (set.Contains(complemant))
            {
                return new int[]{Array.IndexOf(nums, complemant)};
            }
            set.Add(nums[i]);
        }
        throw new ArgumentException("No two sum solution");
    }
}

class Program {
    static void Main() {

    }
}
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProblems;

public class FrequentElements
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                dict[num]++;
            }
            else
            {
                dict[num] = 1;
            }
        }
        
        //set k 
        k = dict.Values.Max();
        
        //find frequent numbers
        var mostFrequentElements = dict
            .Where(x => x.Value == k)
            .Select(x => x.Key)
            .ToList();
            
      
    }
}
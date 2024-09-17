using System;
using System.Collections.Generic;
using System.Linq;

public class Soluti {
    public List<IList<string>> GroupAnagrams(string[] strs) 
    {
        // Step 1: Create the dictionary to group anagrams
        Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        // Step 2: Process each string
        foreach (string str in strs)
        {
            // Convert to character array and sort
            char[] charArray = str.ToCharArray();
            Array.Sort(charArray);
            string sortedStr = new string(charArray);

            // Add the original string to the dictionary
            if (dict.ContainsKey(sortedStr))
            {
                dict[sortedStr].Add(str);
            }
            else
            {
                dict[sortedStr] = new List<string> { str };
            }
        }

        // Step 3: Return the grouped anagrams
        return dict.Values.ToList<IList<string>>();
    }
}
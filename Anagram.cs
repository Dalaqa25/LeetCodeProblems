using System;

public class AnagramChecker {
    public bool AreAnagrams(string s1, string s2) 
    {
        // Step 1: Check if lengths are different
        if (s1.Length != s2.Length) return false;

        // Step 2: Sort both strings
        char[] sortedS1 = s1.ToCharArray();
        char[] sortedS2 = s2.ToCharArray();
        Array.Sort(sortedS1);
        Array.Sort(sortedS2);

        // Step 3: Compare sorted strings
        return new string(sortedS1) == new string(sortedS2);
    }
}

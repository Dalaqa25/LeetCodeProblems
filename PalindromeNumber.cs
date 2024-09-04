namespace LeetCodeProblems;

public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers are not palindromes
        if (x < 0) return false;
        
        //convert to string
        string s = x.ToString();
        
        // set pointers
        int left = 0;
        int right = s.Length - 1;
        
        
        while (left < right)
        {
            // If they are aren't 
            if (s[left] != s[right])
                return false;
            
            // If they are
            left++;
            right++;
        }

        return true;
    }
}
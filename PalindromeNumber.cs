namespace LeetCodeProblems;

public class PalindromeNumber
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers are not palindromes
        if (x < 0) return false;

        // Convert the number to a string
        string s = x.ToString();

        // Set pointers
        int left = 0;
        int right = s.Length - 1;

        while (left < right) // Keep checking until pointers cross
        {
            if (s[left] != s[right]) // If characters don't match
                return false; // Not a palindrome

            // Move pointers closer to the center
            left++;
            right--;
        }

        // If all characters match, it's a palindrome
        return true;
    }
}
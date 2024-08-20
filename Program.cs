using System;

public class HelloWorld
{
    public bool IsPalindrome(string s)
    {
        //set pointers
        int left = 0; //start
        int right = s.Length - 1;//end of string

        s = s.ToLower();

        while(left < right)
        {
            while(left < right && !char.IsLetterOrDigit(s[left]))
            {
                left ++;
            }
            while(left < right && !char.IsLetterOrDigit(s[right]))
            {
                right --;
            }

            //check if first and last are same
            if (s[left] != s[right])
                return false;

            left++;
            right--;
        }

        return true;
    }
}
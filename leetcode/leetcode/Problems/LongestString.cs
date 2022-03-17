namespace leetcode
{
    static class LongestString
    {
        static public int LengthOfLongestSubstring(string s)
        {
            string workSubString = string.Empty,
             longestString = string.Empty;

            for (var i = 0; i<s.Length;i++)
            {
                if (workSubString.Contains(s[i])) {
                    i = i - workSubString.Length;
                    workSubString = string.Empty;
                } else
                {
                    workSubString = workSubString + s[i];
                }
                if (longestString.Length < workSubString.Length) longestString = workSubString;
            }
            return longestString.Length;
        }
    }
}

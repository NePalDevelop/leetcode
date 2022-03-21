namespace leetcode
{
    public static class LongestPalindromeSolution
    {
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            string longest = s.Substring(0, 1), palindrom;
            int i = 0, left, right;

            while (i<s.Length)
            {

                left = i;
                right = i + 1;

                palindrom = Palindrom(s, left, right);

                if (palindrom.Length > longest.Length) longest = palindrom;

                left = right = i;

                palindrom = Palindrom(s, left, right);

                if (palindrom.Length > longest.Length) longest = palindrom;
                i++;
            }

            return longest;
        }

        private static string Palindrom(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }

            return s[(left + 1)..right];  // левый индекс включается, нижний НЕ включается
        }
    }
}

using System;
using System.Linq;

namespace leetcode

{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] nums = { 2, 7, 11, 15 };
            //var target = 9;
            //Solution s = new();
            //int[] result = s.TwoSum(nums, target);
            //foreach (var a in result) Console.WriteLine(a);

            //int x = int.MaxValue-1;
            //int x = 201202;

            //Solution3 s = new();

            //Console.WriteLine(s.isPalindrome(x));

            //string s1 = "2.5.034";
            //string s2 = "2.5.34.001";
            //Solution4 s = new();
            //var i = s.CompareVersion(s1, s2);
            //Console.WriteLine(i);
            ListNode l1, l2, l;

            //l1 = new ListNode(1, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9, new ListNode
            //                 (9))))))))));

            //l2 = new ListNode //(9, new ListNode
            //                  // (9, new ListNode
            //                  //(9, new ListNode
            //                 (9); 
            //                 //(new ListNode(9));

            //l = Solution5.AddTwoNumbers(l1, l2);

            //while (l != null)
            //{
            //    Console.Write(l.val);
            //    l = l.next;

            //}

            var s = " ";
            var num = 1994;

            Console.WriteLine(AToI.MyAtoi(s));

        }


    }

    /// <summary>
    ///  поиск двух чисел в сумме равных target
    /// </summary>

    public class Solution
    {

        public int[] TwoSum(int[] nums, int target)
        {

            int[] result = { 0, 0 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }
    }


    // Задача на палиндром
    // медленнее, но требует меньше памяти

    class Solution2
    {
        public bool isPalindrome(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0)) return false;
            return reverse(x) == x;
        }
        int reverse(int x)
        {

            int res = 0;
            while (x != 0)
            {
                //                if (res > int.MaxValue / 10) return -1;
                res = res * 10 + x % 10;
                x /= 10;
            }
            return res;
        }
    };
}

/// <summary>
/// быстро но больше памяти
/// </summary>

class Solution3
{
    public bool isPalindrome(int x)
    {
        var str = x.ToString();
        int j = str.Length - 1;
        int i = 0;
        while (i <= j && str[i] == str[j])
        {
            i++;
            j--;
        }
        return i >= j;
    }

}

class Solution4
{
    public int CompareVersion(string version1, string version2)
    {

        var str1 = version1.Split(".").Select(x => int.Parse(x)).ToList();
        var str2 = version2.Split(".").Select(x => int.Parse(x)).ToList();
        var l1 = str1.Count;
        var l2 = str2.Count;
        var i = 0;

        while (i < l1 && i < l2)
        {
            if (str1[i] > str2[i]) return 1;
            if (str1[i] < str2[i]) return -1;
            i++;
        }

        if (l1 > l2)
        {
            for (var j = i; j < l1; j++)
            {
                if (str1[j] != 0) return 1;
            }
        }
        else if (l2 > l1)
        {
            for (var j = i; j < l2; j++)
            {
                if (str2[j] != 0) return -1;
            }
        }
        return 0;
    }
}

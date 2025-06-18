using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode169
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 1) { return nums[0]; }
            Dictionary<int, int> counts = new();
            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                {
                    counts[num]++;
                    if (counts[num] >= (nums.Length + 1) / 2)
                    {
                        return num;
                    }
                }
                else
                {
                    counts[num] = 1;
                }
            }
            return 0; // this should never get called due to constraints
        }
    }
}

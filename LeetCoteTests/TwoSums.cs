using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoteTests
{
    public class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int index = 0;
            while (index < nums.Length-1)
            {
                for (int i = index+1; i < nums.Length-1; i++)
                {
                    if (nums[index] + nums[i] == target)
                    {
                        return new int[] {index, i };
                    }
                }
                index++;
            }
            return null;
        }
    }
}

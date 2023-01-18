using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCoteTests
{
    public class MaxSumCircularSubArray
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            var max = int.MinValue;
            var sum = 0;
            var numsSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                numsSum += nums[i];
                sum += nums[i];
                if (sum > max) max = sum;
                if (sum < 0) sum = 0;
            }
            var min = int.MaxValue;
            sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < min) min = sum;
                if (sum > 0) sum = 0;
            }

            if (numsSum == min) return max;

            return max > numsSum - min ? max : numsSum - min;
        }
    }
}

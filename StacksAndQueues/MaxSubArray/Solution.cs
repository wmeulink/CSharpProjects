using System;
using System.Collections.Generic;
using System.Text;

namespace MaxSubArray
{
    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            return Helper(nums, 0, nums.Length - 1);

        }


        private int CrossSum(int[] nums, int left, int right, int p) {
            if (left == right) {
                return nums[left];
            }
            int leftSubSum = 0;
            int currSum = 0;

            for (int i = p; i > left - 1; --i) {
                currSum += nums[i];
                leftSubSum = Math.Max(leftSubSum, currSum);

            }
            int rightSubSum = 0;
            currSum = 0;
            for (int i = p+1; i < right + 1; ++i) {
                currSum += nums[i];
                rightSubSum = Math.Max(rightSubSum, currSum);

            }
            return leftSubSum + rightSubSum;
        }

        private int Helper(int[] nums, int left, int right) {
            if (left == right) return nums[left];
            int p = (left + right) / 2;
            int leftSum = Helper(nums, left, p);
            int rightSum = Helper(nums, p + 1, right);
            int crossSum = CrossSum(nums, left, right, p);

            return Math.Max(Math.Max(leftSum, rightSum), crossSum);
        }
    }

}

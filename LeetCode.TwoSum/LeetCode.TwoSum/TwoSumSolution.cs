using System;
using System.Collections.Generic;

namespace LeetCode.TwoSum
{
    public class TwoSumSolution
    {
        public TwoSumSolution()
        {

        }
        public int[] TwoSum(int[] nums, int target)
        {
            bool stop = false;
            List<int> indexesOfResultNumbers = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {                
                for (int j = i + 1; j < nums.Length; j++)
                {                
                    int sumOfTwoNumbers = nums[i] + nums[j];
                 
                    if(sumOfTwoNumbers == target)
                    {
                        indexesOfResultNumbers.Add(i);
                        indexesOfResultNumbers.Add(j);
                        stop = true;
                        break;
                    }
                }
                if (stop) break;
            }
            
            return indexesOfResultNumbers.ToArray();
        }
    }
}

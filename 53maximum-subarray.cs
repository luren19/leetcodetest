public class Solution {
    public int MaxSubArray(int[] nums) {
        int maxEndingHere = nums[0];
        int maxTotal = maxEndingHere;
        for(int i = 1;i<nums.Length;i++)
        {
            maxEndingHere = Math.Max(maxEndingHere + nums[i], nums[i]);
            maxTotal = Math.Max(maxEndingHere,maxTotal);
        }
        return maxTotal;        
    }
}

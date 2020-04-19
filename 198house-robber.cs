public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 0) return 0;
        if(nums.Length == 1) return nums[0];
        if(nums.Length == 2) return Math.Max(nums[0], nums[1]);
        int[] result = new int[nums.Length];
        result[0] = nums[0];
        result[1] = Math.Max(nums[0], nums[1]);
        result[2] = Math.Max(result[1], result[0]+nums[2]);
        int max = result[2];
        for(int i=3; i<nums.Length; i++){
            result[i] = nums[i] + Math.Max(result[i-2],result[i-3]);
            max = Math.Max(result[i],max);
        }
        return max;
    }
}

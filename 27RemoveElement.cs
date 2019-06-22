public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int count = 0;
        for(int j=0;j<nums.Length;j++)
        {
            if(nums[j]!=val)
            {
                nums[count]=nums[j];
                count++;
            }
        }
        return count;        
    }
}

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
    
    public int RemoveElement2(int[] nums, int val) {
        int i = 0;
        int total = nums.Length;
        while(i<total)
        {
            if(nums[i]==val)
            {
                nums[i]=nums[total-1];
                total--;
            }
            else
            {
                i++;
            }
        }        
        return total;        
    }
}

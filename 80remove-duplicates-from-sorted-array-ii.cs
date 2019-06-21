public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if(nums.Length <=2)
        {
            return nums.Length;
        }        
        int i = 0;
        int count = 1;
        for(int j = 1; j<nums.Length;j++)
        {
            if(nums[j]!=nums[i])
            {                
                if(count>=2)
                {
                    nums[i+1]=nums[i];
                    i=i+2;
                }
                else
                {
                    i=i+1;
                }
                count = 1;
                nums[i]=nums[j];
            }
            else
            {
                count++;
            }                
        }
        if(count>=2)
        {
            nums[i+1]=nums[i];
            i++;          
        }
        return i+1;        
    }
}

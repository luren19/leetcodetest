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

    public int RemoveDuplicates2(int[] nums) {
        int limit=2;
        if(nums.Length <=limit)
        {
            return nums.Length;
        }        
        int i = 1;
        int count = 1;
        int temp = nums[0];
        for(int j = 1; j<nums.Length;j++)
        {
            if(nums[j]!=temp)
            {                
                count = 1;
                nums[i]=nums[j];
                i++;
                temp = nums[j];                
            }
            else
            {
                if(count>=limit)
                {
                    continue;
                }
                else
                {
                    count++;
                    nums[i]=temp;
                    i++;
                }
            }                
        }
        
        return i;        
    }
}

public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Length == 0)
        {
            return 0;
        }
        int i = 0;                
        for(;i<nums.Length;i++)
        {
            //Console.WriteLine(nums[i]);
            if(nums[i]>=target)
            {
                return i;
            }
        }
        return i;        
    }
    
    public int SearchInsert2(int[] nums, int target) {
        if(nums.Length == 0)
        {
            return 0;
        }        
        int result = BinarySearch(nums,target,0,nums.Length-1);
        return result;
    }
    
    public int BinarySearch(int[] nums, int target,int sindex,int eindex)
    {
        //Console.WriteLine(sindex + " " + eindex);
        if(sindex == eindex)
        {
            if(nums[sindex]>=target)
            {
                return sindex;
            }
            else
            {
                return sindex+1;
            }
        }
        int mindex = (eindex-sindex)/2 + sindex;
        if(nums[mindex]==target)
        {
            return mindex;
        }
        else if(nums[mindex]<target)
        {
            sindex = mindex + 1;
            //return BinarySearch(nums,target,sindex,eindex);
        }
        else
        {
            eindex = (mindex-1);
            if(eindex < sindex)
            {
                eindex = sindex;
            }
            //return BinarySearch(nums,target,sindex,eindex);
        }
        return BinarySearch(nums,target,sindex,eindex);
    }
}

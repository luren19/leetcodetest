public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int i=m-1;
        int j=n-1;
        while(i>=0&&j>=0)
        {
            if(nums1[i]>nums2[j])
            {
                nums1[i+j+1]=nums1[i--];
            }
            else
            {
                nums1[i+j+1]=nums2[j--];
            } 
        }
        if(i<0)
        {
            while(j>=0)
            {
                nums1[i+j+1]=nums2[j--];
            }
        }
        else
        {
            while(i>=0)
            {
                nums1[i+j+1]=nums1[i--];
            }
        }        
    }
}

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;       
        while(left<right)
        {
            int mindex = (right-left)/2 + left;
            if(IsBadVersion(mindex))
            {
                right = mindex;
            }
            else
            {
                left = mindex + 1;
            }
        }
        return left;
    }
}

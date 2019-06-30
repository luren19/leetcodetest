// Forward declaration of guess API.
// @param num, your guess
// @return -1 if my number is lower, 1 if my number is higher, otherwise return 0
int guess(int num);

class Solution {
public:
    int guessNumber(int n) {
        int left = 1;
        int right = n;
        while(left<right)
        {
            int mindex = (right-left)/2+left;
            int tempresult = guess(mindex);
            switch(tempresult)
            {
                case 0:
                    return mindex;
                case -1:
                    right = mindex-1;
                    break;
                case 1:
                    left = mindex+1;
                    break;
            }            
        }
        return left;        
    }
};

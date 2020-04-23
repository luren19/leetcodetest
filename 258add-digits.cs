public class Solution {
    public int AddDigits(int num) {
        if(num < 10){
            return num;
        }
        else{
            return 1 + (num-1)%9;
        }
    }
}

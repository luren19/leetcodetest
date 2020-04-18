public class Solution {
    public int HammingWeight(uint n) {
        int result = 0;
        // for(int i = 0; i < 32; i++){
        while(n != 0){
            result += Convert.ToInt32(n & 1);
            n >>= 1;
        }
        return result;
    }
    
    public int HammingWeight(uint n) {
        int result = 0;
        while(n != 0){
            // n & (n - 1) drops the lowest set bit.
            n &= (n-1);
            result++;
        }
        return result;
    }
}

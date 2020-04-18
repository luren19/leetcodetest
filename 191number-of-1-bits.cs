public class Solution {
    public int HammingWeight(uint n) {
        int result = 0;
        for(int i = 0; i < 32; i++){
            result += Convert.ToInt32(n & 1);
            n >>= 1;
        }
        return result;
    }
}

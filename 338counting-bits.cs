public class Solution {
    public int[] CountBits(int num) {
        if(num < 0) return null;
        if(num == 0) return new int[1]{0};
        int[] result = new int[num+1];
        int recur = 1;
        result[0] = 0;
        result[1] = 1;
        if(num == 1) return result;
        for(int i = 2; i <= num; i++){
            recur *= 2;
            int j = 0;
            while(j < recur && i <= num){
                result[i++] = 1 + result[j++];
            }
            i--;            
        }
        return result;
    }
    
    public int[] CountBits(int num) {
        int[] result = new int[num+1];
        result[0] = 0;
        for(int i = 1; i <= num; i++){
            result[i] = result[i>>1] + (i & 1);
        }
        return result;
    }
}

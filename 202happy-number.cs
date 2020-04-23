public class Solution {
    public bool IsHappy(int n) {
        HashSet<int> tempResult = new HashSet<int>();
        while(tempResult.Add(n)){
            int tempSummary = 0;
            while(n>0){
                int temp = n % 10;
                n /= 10;
                tempSummary += temp * temp;
            }
            if(tempSummary == 1 ){
                return true;
            }
            else{
                n = tempSummary;
            }            
        }
        return false;
    }
    
    public bool IsHappy2(int n) {
        int slow, fast;
        slow = fast = n;
        do{
            slow = CalcSumOfDigitsSquares(slow);
            fast = CalcSumOfDigitsSquares(fast);
            fast = CalcSumOfDigitsSquares(fast);
            if(fast == 1){
                return true;
            }
        }while(slow != fast);
        return false;
    }
    
    private int CalcSumOfDigitsSquares(int n){
        int summary = 0;
        while(n>0){
            int temp = n % 10;
            n /= 10;
            summary += temp*temp;
        }
        return summary;
    }
}

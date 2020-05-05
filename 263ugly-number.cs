public class Solution {
    public bool IsUgly(int num) {        
        for(int i=2; i<=5 && num>=i;i++){
            while(num%i==0){
                num /= i;
            }            
        }
        return num==1;        
    }
}

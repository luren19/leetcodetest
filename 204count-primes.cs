public class Solution {
    public int CountPrimes(int n) {
        if(n<=1) return 0;
        bool[] NotPrimes = new bool[n];
        NotPrimes[0] = true;
        NotPrimes[1] = true;
        int count = 0;
        for(int i=2; i<Math.Sqrt(n);i++){
            if(!NotPrimes[i]){
                for(int j=i*i;j<n;j+=i){
                    NotPrimes[j]=true;
                }
            }
        }
        for(int i=2; i<n;i++){
            if(!NotPrimes[i]){
                count++;
            }
        }
        return count;
    }
}

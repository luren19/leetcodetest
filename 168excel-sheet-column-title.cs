public class Solution {
    public string ConvertToTitle(int n) {
        if(n==0){
            return "";
        }
        else{
            int quo = n / 26;
            int res = n % 26;
            char temp = (char)((n-1)%26 + 'A');
            n = (res == 0)?(n/26-1):quo;
            return ConvertToTitle(n)+temp.ToString();
        }
    }
}

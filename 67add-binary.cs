public class Solution {
    public string AddBinary(string a, string b) {
        int aLen = a.Length;
        int bLen = b.Length;
        int minLen = aLen >= bLen?bLen:aLen;
        int maxLen = aLen >= bLen?aLen:bLen;
        string maxLenStr = aLen >= bLen?a:b; 
        int plus = 0;
        int sum = 0;
        int i = 1;
        string result = "";
        while(i<=minLen)
        {
            //Console.WriteLine($"{sum},{plus},{result},{i}");
            sum = plus + a[aLen-i]-'0'+b[bLen-i]-'0';
            plus = sum/2;
            result = sum%2 + result;
            i++;
            //Console.WriteLine($"{sum},{plus},{result},{i}");
        }
        while(i<=maxLen)
        {
            sum = plus + maxLenStr[maxLen-i]-'0';
            plus = sum/2;
            result = sum%2 + result;
            i++;
            //Console.WriteLine($"{sum},{plus},{result},{i}");
        }
        if(plus > 0)
        {
            //Console.WriteLine(plus);
            result = plus + result;
        }
        return result;
    }
    
    public string AddBinary2(string a, string b) {       
        int plus = 0;
        int sum = 0;
        string result = "";
        int i=a.Length-1;
        int j=b.Length-1;
        while(i>=0||j>=0)
        {
            sum = plus;
            if(i>=0)
            {
                sum += a[i--]-'0';
            }
            if(j>=0)
            {
                sum += b[j--]-'0';
            }
            plus = sum/2;
            result = sum%2 + result;
            //Console.WriteLine($"{sum},{plus},{result},{i},{j}");
        }
        if(plus>0)
        {
            result = plus + result;
        }
        return result;
    }
}

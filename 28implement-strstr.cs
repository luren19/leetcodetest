public class Solution {
    public int StrStr(string haystack, string needle) {
        if(string.IsNullOrEmpty(needle))
        {
            return 0;
        }
        /*if(string.IsNullOrEmpty(haystack))
        {
            return -1;
        }*/
        int needleLength = needle.Length;
        int haystackLength = haystack.Length;
        int result = -1;

        for(int i = 0;i<=haystackLength-needleLength;i++)
        {
            if(haystack[i]==needle[0]&&haystack[i+needleLength-1]==needle[needleLength-1])
            {
                if(needleLength==1)
                {
                    result=i;
                    break;
                }
                int j=1;
                for(;j<needleLength-1;j++)
                {
                    if(haystack[i+j]!=needle[j])
                    {                        
                        break;
                    }
                }
                if(j==needleLength-1)
                {
                    result = i;
                    break;
                }              
            }                   
        }
        return result;
    }
}

public class Solution {
    public string LongestCommonPrefix-HorizontalScanning(string[] strs) 
    {
        if(strs.Length == 0) return "";
        string prefix = strs[0];
        for(int i = 1; i<strs.Length;i++)
        {
            while(strs[i].IndexOf(prefix) !=0)
            {
                prefix = prefix.Substring(0, prefix.Length -1);
                if(string.IsNullOrEmpty(prefix)) return "";
            }
            
        }
        return prefix;        
    }
    
    public string LongestCommonPrefix-VerticalScanning(string[] strs) 
    {
        if(strs.Length == 0) return "";
        for(int i = 0; i<strs[0].Length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if( i == strs[j].Length || c.CompareTo(strs[j][i]) != 0)
                    return strs[0].Substring(0,i);
            }
        }
        return strs[0];      
    }
}

public class SolutionDivideAndConquer {
    public string LongestCommonPrefix(string[] strs) 
    {
        if(strs.Length == 0) return "";
        return LongestCommonPrefix(strs, 0, strs.Length -1);      
    }
    
    private string LongestCommonPrefix(string[] strs, int l, int r)
    {
        if(l == r)
        {
           return strs[l]; 
        }
        else
        {
            int mid = (l+r)/2;
            string lcpLeft = LongestCommonPrefix(strs, l, mid);
            string lcpRight = LongestCommonPrefix(strs, mid+1, r);
            return commonPrefix(lcpLeft, lcpRight);
        }
    }
    
    private string commonPrefix(string left, string right)
    {
        int min = Math.Min(left.Length, right.Length);
        for(int i = 0; i<min; i++)
        {
           if(left[i].CompareTo(right[i])!=0)
               return left.Substring(0,i);
        }
        return left.Substring(0,min);
            
    }
}


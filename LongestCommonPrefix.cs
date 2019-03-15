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


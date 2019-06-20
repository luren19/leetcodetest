public class Solution {
    public bool IsValid(string s) {
        if(String.IsNullOrEmpty(s))
        {
            return true;
        }
        Stack<char> temp = new Stack<char>();
        Hashtable mappings = new Hashtable();
        mappings.Add(')','(');
        mappings.Add('}','{');
        mappings.Add(']','[');
        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(mappings.ContainsKey(c))
            {
                if(temp.Count == 0)
                {
                    return false;
                }
                if(temp.Pop() != Convert.ToChar(mappings[c]))
                {
                    return false;
                }
            }
            else
            {
                temp.Push(c);
            }                        
        }
        if(temp.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

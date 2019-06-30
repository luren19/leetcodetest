public class Solution {
    public string CountAndSay(int n) {
        if(n==1)
        {
            return "1";
        }
        var temp = CountAndSay(n-1) + "*";
        //var temp = CountAndSay(n-1);
        int count = 1;
        StringBuilder result = new StringBuilder();
        for(int i=0;i<temp.Length-1;i++)
        //for(int i=0;i<temp.Length;i++)
        {
            if(temp[i]!=temp[i+1])
            //if(i==temp.Length-1 || temp[i] !=temp[i+1])
            {
                //Console.WriteLine(i+"  "+count + "  "+temp[i]);
                result.Append(count);
                result.Append(temp[i]);
                count = 1;
            }
            else
            {
                count++;
            }
        }
        //Console.WriteLine("result for " + n + "is:" + result.ToString());
        return result.ToString();
    }
}

public class Solution {
    public int[] SortedSquares(int[] A) {
        int len = A.Length;
        int i=0;
        while(i<len&&A[i]<0)
        {
            i++;
        }
        int j=i-1;
        int[] result = new int[len];
        int k = 0;
        int templ,tempr;
        while(j>=0&&i<len)
        {
            templ = A[j]*A[j];
            tempr= A[i]*A[i];
            if(templ<tempr)
            {
                result[k++]=templ;
                j--;
            }
            else
            {
                result[k++]=tempr;
                i++;
            }
        }
        while(j>=0)
        {
            result[k++]=A[j]*A[j];
            j--;
        }
        while(i<len)
        {
            result[k++]=A[i]*A[i];
            i++;
        }
        
        return result;
    }
}

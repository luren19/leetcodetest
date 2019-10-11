public class Solution {
    public IList<int> GetRow(int rowIndex) {        
        List<int> row = new List<int>();
        
        for(int rowNum = 0; rowNum <= rowIndex;rowNum++)
        {
            row.Insert(0,1);
            for(int j = 1; j < row.Count-1; j++)
            {
                row[j] = row[j] + row[j+1];
            }
        }
        
        return row;
    }
}

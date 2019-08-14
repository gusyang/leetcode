/*
Given a collection of intervals, merge all overlapping intervals.
Example 1:
Input: [[1,3],[2,6],[8,10],[15,18]]
Output: [[1,6],[8,10],[15,18]]
Explanation: Since intervals [1,3] and [2,6] overlaps, merge them into [1,6].

Example 2:
Input: [[1,4],[4,5]]
Output: [[1,5]]
Explanation: Intervals [1,4] and [4,5] are considered overlapping.
NOTE: input types have been changed on April 15, 2019. Please reset to default code definition to get new method signature.
 */
public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        List<int[]> result = new List<int[]>();
        if(intervals == null || intervals.Length == 0 || intervals[0] == null || intervals[0].Length == 0) return result.ToArray();
        int len = intervals.Length;
        int[] startInterval = new int[len];
        int[] endInterval = new int[len];
/* doesnt work
        Array.Sort(intervals,(i1,i2) =>{
            i1[0].CompareTo(i2[0]);
        });
*/
        //split different start and end array
        for(int j = 0; j < len; j++){
            startInterval[j] = intervals[j][0];
            endInterval[j] = intervals[j][1];
        }
        //sort array
        Array.Sort(startInterval);
        Array.Sort(endInterval);

        int i = 0;
        while (i < len)
        {
            int st = startInterval[i];
            //if next start smaller than current end, 
            //overlaps, need merge to next end;
            while (i < len - 1 && startInterval[i + 1] <= endInterval[i])
            {
                i++;
            }
            int en = endInterval[i];
            result.Add(new int[]{st,en});
            i++;            
        }
        return result.ToArray();

    }
}
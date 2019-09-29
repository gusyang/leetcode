/* 
Given a set of non-overlapping intervals, insert a new interval into the intervals(merge if necessary).
You may assume that the intervals were initially sorted according to their start times.
Example 1:
Input: intervals = [[1, 3], [6,9]], newInterval = [2,5]
Output: [[1,5],[6,9]]

Example 2:
Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
Output: [[1,2],[3,10],[12,16]]
Explanation: Because the new interval[4, 8] overlaps with[3, 5],[6,7],[8,10].
*/
public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        List<int[]> res = new List<int[]>();
        foreach(int[] interval in intervals){
            if(interval[1] < newInterval[0])
            { 
                res.Add(interval);
            } else if(interval[0] > newInterval[1]){
                res.Add(newInterval);
                newInterval = interval;
            } else if(interval[1] >= newInterval[0] || interval[0] <= newInterval[1]){
                newInterval = new int[]{Math.Min(interval[0],newInterval[0]), Math.Max(interval[1],newInterval[1])};
            }
        }
        res.Add(newInterval);
        return res.ToArray();    

    }
}

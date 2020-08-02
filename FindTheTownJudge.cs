using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    #region challenge description
    /*
     * https://leetcode.com/problems/find-the-town-judge/
     * 
     *  In a town, there are N people labelled from 1 to N.  There is a rumor that one of these people is secretly the town judge.
        If the town judge exists, then:
        -The town judge trusts nobody.
        -Everybody (except for the town judge) trusts the town judge.
        -There is exactly one person that satisfies properties 1 and 2.
        You are given trust, an array of pairs trust[i] = [a, b] representing that the person labelled a trusts the person labelled b.
        If the town judge exists and can be identified, return the label of the town judge.  Otherwise, return -1.
     * 
     Example 1:
        Input: N = 2, trust = [[1,2]]
        Output: 2

     Example 2:
        Input: N = 3, trust = [[1,3],[2,3]]
        Output: 3

     Example 3:
        Input: N = 3, trust = [[1,3],[2,3],[3,1]]
        Output: -1

     Example 4:
        Input: N = 3, trust = [[1,2],[2,3]]
        Output: -1

     Example 5:
        Input: N = 4, trust = [[1,3],[1,4],[2,3],[2,4],[4,3]]
        Output: 3
         */
    #endregion
    public class FindTheTownJudge
    {
        //public int FindJudge(int N, int[][] trust)
        //{
        //    if (N == 1) return 1;

        //    var dict = new Dictionary<int, int>();
        //    var trusting = new HashSet<int>();

        //    foreach (int[] t in trust)
        //    {
        //        if (dict.ContainsKey(t[1]))
        //        {
        //            dict[t[1]]++;
        //        }
        //        else
        //        {
        //            dict.Add(t[1], 1);
        //        }

        //        trusting.Add(t[0]);
        //    }

        //    foreach (var pair in dict)
        //    {
        //        if (pair.Value == (N - 1) && !trusting.Contains(pair.Key))
        //        {
        //            return pair.Key;
        //        }
        //    }

        //    return -1;

        //}

        public int FindJudge(int N, int[][] trust)
        {
            int[] trustPoints = new int[N + 1];
            var trusting = new HashSet<int>();

            for (var i = 0; i < trust.Length; i++)
            {
                trustPoints[trust[i][1]]++;
                trusting.Add(trust[i][0]);
            }


            for (var j = 1; j <= N; j++)
            {
                if (trustPoints[j] == N - 1 && !trusting.Contains(j))
                {
                    return j;
                }
            }

            return -1;
        }
    }


    /*
     * NOTES:
     * To match numeric values with accumulations or number of repetitions of these numbers
     * the approach is to create an empty array (if possible) and accumulate (++) or count the values
     * and assign them using the number itself to specify an index in the brand new array
     * 
     */
}

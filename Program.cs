using System;

namespace Solutions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var judge = new FindTheTownJudge();
            var trust = new int[][]
            {
                new int[]{1,3},
                new int[]{2,3},
                new int[]{3,1}

            };

            Console.WriteLine(judge.FindJudge(3, trust));
        }
    }
}

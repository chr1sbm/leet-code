using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class TestIter
    {
        public IEnumerable<string> ChunkIter(string s, int chunks)
        {
            int length = s.Length;
            if (chunks < 1) throw new ArgumentException("Chunks must be greater than zero");
            int division = length / chunks;
            int rest = length % chunks;
            var dict = new Dictionary<int, int>();
            if (chunks > length) chunks = length;
            var result = new string[chunks];

            for (var i = 0; i < chunks; i++)
            {
                dict.Add(i, division);
            }

            if (rest > 0)
            {
                for (var i = 0; i < rest; i++)
                {
                    dict[i]++;
                }
            }

            int startIndex = 0;

            foreach (var pair in dict)
            {
                result[pair.Key] = s.Substring(startIndex, pair.Value);
                startIndex += pair.Value;
                yield return result[pair.Key];
            }

            //foreach(string item in result)
            //{
            //    yield return item;
            //}

            
        }
    }


}

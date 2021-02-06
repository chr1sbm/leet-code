using System;

namespace Solutions
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var t = new TestIter();
            var sth = t.ChunkIter("abcdef", 4);
            foreach(var i in sth)
            {
                Console.WriteLine(i);
            }
        }
    }
}

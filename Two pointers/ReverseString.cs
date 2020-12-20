using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions.Two_pointers
{
    public class ReverseString
    {
        public void ReverseStringFunc(char[] s)
        {
            int left = 0;
            int right = s.Length - 1;

            while (left <= right)
            {
                char aux = s[left];
                s[left] = s[right];
                s[right] = aux;
                left++;
                right--;
            }

        }
    }
}


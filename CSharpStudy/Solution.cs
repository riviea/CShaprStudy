using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class Solution
    {
        static public long solution(long n)
        {
            long sqrt = (long)Math.Sqrt(n);
            long answer = sqrt * sqrt;
            return answer == n ? (sqrt + 1) * (sqrt + 1) : -1;
        }

        static public long solution10(long n)
        {
            string temp = n.ToString();

            long answer = long.Parse(temp.OrderByDescending(x => x).ToArray());
            return answer;
        }

        static public bool solution11(int x)
        {
            string str = x.ToString();

            int total = 0;
            foreach (char temp in str)
            {
                total += (int)(temp - '0');
            }

            Console.WriteLine(total);

            if ((x % total) == 0)
                return true;
            return false;
        }
    }
}

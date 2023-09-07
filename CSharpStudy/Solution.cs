using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class Solution
    {
        public static long solution(long n)
        {
            long sqrt = (long)Math.Sqrt(n);
            long answer = sqrt * sqrt;
            return answer == n ? (sqrt + 1) * (sqrt + 1) : -1;
        }

        public static long solution10(long n)
        {
            string temp = n.ToString();

            long answer = long.Parse(temp.OrderByDescending(x => x).ToArray());
            return answer;
        }

        public static bool solution11(int x)
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

        public static decimal solution12(long a, long b)
        {
            if (a == b)
                return a;
            else if (a > b)
            {
                long temp = a;
                a = b;
                b = temp;
            }

            decimal answer = 0;
            for (long i = a; i <= b; ++i)
            {
                answer += i;
            }

            long answer2 = ((b - a) + 1) * (a + b) / 2;

            Console.WriteLine($"{a}, {b}, {answer}, {answer2}");

            return answer;
        }
    }
}

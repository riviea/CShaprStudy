using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class Program
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

            long answer = long.Parse(temp.OrderByDescending(x=>x).ToArray());
            return answer;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", solution10(121345));
        }
    }
}

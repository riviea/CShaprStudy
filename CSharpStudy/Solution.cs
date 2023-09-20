using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class Solution
    {
        // 문제 목록 출저: 
        // https://teamsparta.notion.site/4dfcd24e41604177a10e696209b8094f

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

        /// <summary>
        /// https://school.programmers.co.kr/learn/courses/30/lessons/12943
        /// </summary>
        public static int solution13(long num)
        {
            int count = 0;

            if (num == 1)
                return 1;
            while (num!=1)
            {
                if (num == 1)
                    break;
                else if (count >= 500)
                    return -1;

                if (num % 2 == 0)
                    num /= 2;
                else
                    num = num * 3 + 1;

                count++;
            }

            return count;
        }

        public static string solution14(string[] seoul)
        {
            int cnt;
            for (cnt = 0; cnt < seoul.Length; cnt++)
                if (seoul[cnt].Contains("Kim"))
                    break;

            return "김서방은 " + cnt.ToString() + "에 있다";
        }

        public static int[] solution15(int[] arr, int divisor)
        {
            List<int> list = new List<int>();

            foreach(int i in arr)
            {
                if (i % divisor == 0 && !(list.Contains(i)))
                    list.Add(i);
            }

            if (list.Count == 0)
                list.Add(-1);

            list.Sort();

            return list.ToArray();
        }

        public static int solution16(int[] absolutes, bool[] signs)
        {
            int answer=0;
            for(int i=0; i<absolutes.Length; ++i)
            {
                int sign = signs[i] ? 1 : -1;
                int num = absolutes[i] * sign;
                answer += num;
            }

            return answer;
        }

        public static string solution17(string phone_number)
        {
            char[] str = phone_number.ToCharArray();
            for (int i = 0; i < phone_number.Length - 4; ++i)
                str[i] = '*';

            string answer = new string(str);
            return answer;
        }

        public static int solution18(int[] numbers)
        {
            int total = 45;
            int answer = 0;
            for (int i = 0; i < numbers.Length; ++i)
                answer += numbers[i];
            return total - answer;
        }

        public static int[] solution19(int[] arr)
        {
            if (arr.Length <= 1)
                return new int[1] { -1 };

            int min = arr.Min(i => i);
            List<int> list = new List<int>();
            foreach(int i in arr)
            {
                if (i == min)
                    continue;
                list.Add(i);
            }

            return list.ToArray();
        }
    }
}

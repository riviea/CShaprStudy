using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
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
            while (num != 1)
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

            foreach (int i in arr)
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
            int answer = 0;
            for (int i = 0; i < absolutes.Length; ++i)
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
            foreach (int i in arr)
            {
                if (i == min)
                    continue;
                list.Add(i);
            }

            return list.ToArray();
        }

        public static string solution20(string s)
        {
            StringBuilder answer = new StringBuilder();
            if ((s.Length % 2) == 0)
                answer.Append(s[s.Length / 2 - 1]);
            answer.Append(s[s.Length / 2]);

            return answer.ToString();
        }

        public static string solution21(int n)
        {
            StringBuilder answer = new StringBuilder();
            bool state = false;

            for (int i = 0; i < n; ++i)
            {
                if (!state)
                    answer.Append("수");
                else

                    answer.Append("박");
                state = !state;
            }
            return answer.ToString();
        }

        public static int solution22(int[] a, int[] b)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; ++i)
            {
                sum += a[i] * b[i];
            }

            return sum;
        }

        public static int solution23(int left, int right)
        {
            List<int> elements = new List<int>();
            for (int i = left; i <= right; ++i)
            {
                List<int> divisor = new List<int>();
                for (int j = 1; j <= Math.Sqrt(i); ++j)
                {
                    if (i % j == 0)
                    {
                        divisor.Add(j);
                        if (j != i / j) divisor.Add(i / j); //exclude specific case (ex: 5/5)
                    }

                }

                //foreach (int e in divisor)
                //    Console.Write(e + " ");
                //Console.WriteLine("/");

                int multiplier = divisor.Count % 2 == 0 ? 1 : -1;
                elements.Add(i * multiplier);
            }
            return elements.Sum();
        }

        public static string solution24(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Sort(chars, (x, y) =>
            {
                if ((int)x > (int)y)
                    return -1;
                else if ((int)x < (int)y)
                    return 1;
                else
                    return 0;
            });

            string answer = new string(chars);
            return answer;
        }

        public static long solution25(int price, int money, int count)
        {
            long total = 0;
            for(long i=1; i<=count; ++i)
            {
                total += (price*i);
            }

            if ((money - total) < 0)
                return Math.Abs(total-money);
            return 0;
        }

        public static bool solution26(string s)
        {
            char[] temp = s.ToCharArray();

            if (!((s.Length == 4) || (s.Length == 6)))
                return false;

            for(int i=0; i<temp.Length; ++i)
            {
                if (!((temp[i] >= '0') && (temp[i] <= '9')))
                    return false;
            }
            return true;
        }

        public static int[,] solution27(int[,] arr1, int[,] arr2)
        {
            int k = arr1.GetLength(0);
            int k2 = arr1.GetLength(1);

            int[,] answer = new int[k,k2];

            for(int i=0; i<arr1.GetLength(0); ++i)
            {
                for(int j=0; j<arr1.GetLength(1); ++j)
                {
                    answer[i, j] = arr1[i, j] + arr2[i, j];
                    Console.Write(answer[i, j] + " ");
                }
                Console.WriteLine();
            }
            return answer;
        }

        public static int solution33(int[,] sizes)
        {
            int w = 0, h = 0;
            for (int i=0; i<sizes.GetLength(0); ++i)
            {
                int max = sizes[i, 0];
                int min = sizes[i, 1];

                if (max < min)
                {
                    int temp = max;
                    max = min;
                    min = temp;
                }

                Console.Write(max + " " + min + " ");

                if (max > w) w = max;
                if (min > h) h = min;
            }
            Console.Write(w+ " " + h + " ");
            return w * h;
        }

        public static int[] solution38(int[] array, int[,] commands)
        {
            int hi = commands[0, 1];
            int[] answer = new int[] { };
            return answer;
        }

        public static int[] solution39(int[] numbers)
        {
            SortedSet<int> ints = new SortedSet<int>();
            for(int i=0; i<numbers.Length-1; ++i)
            {
                for(int j=i+1; j<numbers.Length; ++j)
                {
                    Console.Write(numbers[i] + numbers[j] + ",");
                    ints.Add(numbers[i]+numbers[j]);
                }
                Console.WriteLine();
            }
            return ints.ToArray();
        }
    }
}
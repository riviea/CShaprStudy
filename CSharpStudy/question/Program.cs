using CSharpStudy.design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    internal class Program
    {
        public class Item
        {
            int id;
            public void ShowID()
            {
                Console.WriteLine("show: {0}", id);
            }
        }
        static void Main(string[] args)
        {
            Abstract_Factory test = new Abstract_Factory();
            test.Foo();

            //EventTest.EventTestClass.Main();

            return;
            //Console.WriteLine("{0}", Solution.solution21(10));
            //Console.WriteLine("{0}", Solution.solution23(24, 27));
            //Console.WriteLine("{0}", Solution.solution24("aAaBbb"));
            //Console.WriteLine("{0}", Solution.solution27(new int[,] { { 1, 2 }, { 2, 3 } }, new int[,] { { 3, 4 }, { 5, 6 } }));
            //Console.WriteLine("{0}", Solution.solution33(new int[,] { { 10, 7 }, { 2, 3 }, { 8, 15 }, { 14, 7 }, { 5, 15 } }));

            Array.ForEach(Solution.solution39(new int[] { 2, 1, 3, 4, 1 }), num => Console.Write(num + ", "));

            //NaturalNubmer ints = new NaturalNubmer();
            
            //foreach (int i in ints)
            //{
            //    if (i == 100)
            //        break;
            //    Console.Write(i+" ");
            //}
            //Console.WriteLine();

            //foreach(int i in YieldTest.Next(100))
            //{
            //    Console.Write(i + " ");
            //}

            //LambdaTest.Foo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    public class LambdaTest
    {
        delegate int? MyDivide(int a, int b);
        delegate int MyAdd(int a, int b);

        public static void Foo()
        {
            Thread thread = new Thread(
                (obj) =>
                {
                    Console.WriteLine("Anonymous method called!");
                });

            MyDivide myFunc = (a, b) =>
            {
                if (b == 0)
                    return null;
                return a / b;
            };

            MyAdd myAdd = (a, b) => a + b;

            Console.WriteLine("10/2==" + myFunc(10, 2));
            Console.WriteLine("10+2==" + myAdd(10, 2));

            List<int> list = new List<int> { 1,2,3,4,5};
            int count = list.Count((elem) => (elem > 3));
            Console.WriteLine("count: " + count);
        }
    }
}

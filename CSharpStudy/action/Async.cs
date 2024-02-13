using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharpStudy
{
    public class AsyncTest
    {
        static void Foo()
        {
            int result3 = Method3();
            int result5 = Method5();

            Console.WriteLine(result3 + result5);
        }

        private static int Method3()
        {
            Thread.Sleep(3000);
            return 3;
        }

        private static int Method5()
        {
            Thread.Sleep(5000);
            return 5;
        }
    }
}

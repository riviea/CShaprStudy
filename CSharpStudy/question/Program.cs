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
            FactoryTest.Foo();
        }
    }
}

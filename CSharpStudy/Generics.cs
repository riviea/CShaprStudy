using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    interface ICanTest
    {
        //...
    }

    class GenericsTest<T> where T : class, ICanTest
    {
        private T _value;

        public void Foo(T value)
        {
            _value = value;
        }
    }

    class CanUseType : ICanTest
    {
        //...
    }

    class GenericsTest2<K, T>
    {
        private K _key;
        private T _value;

        public void Foo(K key, T value)
        {
            _key = key;
            _value = value;
        }
    }
}

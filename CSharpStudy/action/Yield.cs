using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    public class NaturalNubmer : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new NaturalNumberEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new NaturalNumberEnumerator();
        }
    }

    public class NaturalNumberEnumerator : IEnumerator<int>
    {
        int _current;

        public int Current { get { return _current; } }
        object IEnumerator.Current {  get { return _current; } }

        public void Dispose() { }
        public bool MoveNext() { _current++; return true; }
        public void Reset() { _current = 0; }
    }

    internal class YieldTest
    {
        public static IEnumerable<int> Next(int max)
        {
            int _start = 0;
            while(true)
            {
                if( _start < max ) yield break;
                _start++;
                yield return _start;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    abstract class Iterator : IEnumerator
    {
        public abstract int Key();
        public abstract object Current { get; }

        public abstract bool MoveNext();
        public abstract void Reset();
    }

    public abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}

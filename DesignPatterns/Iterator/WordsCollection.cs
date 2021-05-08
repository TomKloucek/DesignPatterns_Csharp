using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    public class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();
        bool _direction = false;

        public void reverseDirection()
        {
            _direction = !_direction;
        }

        public List<string> getItems()
        {
            return _collection;
        }

        public void AddItem(string item)
        {
            this._collection.Add(item);
        }

        public override System.Collections.IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }

    }
}

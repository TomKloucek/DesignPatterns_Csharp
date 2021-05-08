using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator
{
    class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _collection;

        private int _position = -1;
        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                _position = _collection.getItems().Count;
            }
        }

        public override object Current => this._collection.getItems()[_position];

        public override int Key() => this._position;

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.getItems().Count : -1;
        }
    }
}

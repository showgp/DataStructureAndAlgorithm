using System.Collections;
using System.Collections.Generic;

namespace C1 {
    public class FixedCapacityStackOfStrings : IFixedCapacityStackOfStrings {
        private readonly string[] _arr;
        private int _size;
        private readonly int _capacity;

        public FixedCapacityStackOfStrings(int capacity) {
            _capacity = capacity;
            _arr = new string[capacity];
        }

        public bool IsEmpty() => _size == 0;

        public string Pop() => _size > 0 ? _arr[_size--] : null;

        public void Push(string s) {
            if (_size < _capacity) _arr[++_size] = s;
        }

        public int Size() => _size;
    }

    public class FixedCapacityStack<Item> : IFixedCapacityStack<Item> {
        private readonly Item[] _arr;
        private int _top;
        private readonly int _capacity;

        public FixedCapacityStack(int capacity) {
            _capacity = capacity;
            _arr = new Item[capacity];
        }

        public bool IsEmpty() => _top == 0;

        public Item Pop() => _top > 0 ? _arr[--_top] : default;

        public void Push(Item s) {
            if (_top < _capacity) _arr[_top++] = s;
        }

        public int Size() => _top;

        public IEnumerator<Item> GetEnumerator() => new ReverseEnumerator<Item>(_arr, Size());

        IEnumerator IEnumerable.GetEnumerator() => new ReverseEnumerator<Item>(_arr, Size());
    }

    internal class ReverseEnumerator<Item> : IEnumerator<Item> {
        private Item[] _arr;
        private int _currentIndex;

        public ReverseEnumerator(Item[] arr, int totalLength) {
            _arr = arr;
            _currentIndex = totalLength;
        }

        public Item Current => _arr[_currentIndex];

        object IEnumerator.Current => _arr[_currentIndex];

        public void Dispose() {
            _arr = null;
        }

        public bool MoveNext() {
            return (--_currentIndex) >= 0;
        }

        public void Reset() {
            throw new System.NotImplementedException();
        }
    }
}
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
    }
}
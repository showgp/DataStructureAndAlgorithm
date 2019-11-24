using C1.Interfaces;

namespace C1.Implementations {
    public class SingleLinkedList<Item> : ISingleLinkedList<Item> {
        public ISingleLinkedListNode<Item> Last => _last;
        private ISingleLinkedListNode<Item> _last;

        public ISingleLinkedListNode<Item> Head => _head;
        private ISingleLinkedListNode<Item> _head;

        private int _size = 0;

        public SingleLinkedList() {
            _head = new SingleLinkedListNode<Item>(default, null);
            _last = _head;
        }

        public void InsertAtEnd(Item item) {
            var node = new SingleLinkedListNode<Item>(item, null);
            _last.Next = node;
            _last = node;
            _size++;
        }

        public void InsertAtStart(Item item) {
            var node = new SingleLinkedListNode<Item>(item, _head.Next);
            _head.Next = node;
            _size++;
            if (_last == _head) { // 空表插入的情况
                _last = node;
            }
        }

        public Item RemoveFromEnd() {
            if (IsEmpty()) return default;
            var preLast = _head;
            while (preLast.Next != _last) {
                preLast = preLast.Next;
            }
            var lastNode = _last;
            _last = preLast;
            _last.Next = null;
            _size--;
            return lastNode.Value;
        }

        public Item RemoveFromStart() {
            if (IsEmpty()) return default;
            var node = _head.Next;
            _head.Next = node.Next;
            _size--;
            if (_size == 0) {
                _last = _head;
            }
            return node.Value;
        }

        public int Size() => _size;

        public bool IsEmpty() => _size == 0;
    }
}
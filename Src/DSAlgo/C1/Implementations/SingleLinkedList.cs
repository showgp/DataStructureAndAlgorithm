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
            _last = null;
        }

        public void InsertAtEnd(Item item) {
            throw new System.NotImplementedException();
        }

        public void InsertAtStart(Item item) {
            var node = new SingleLinkedListNode<Item>(item, _head.Next);
            _head.Next = node;
            _size++;
            if (_last == null) { // 空表插入的情况
                _last = node;
            }
        }

        public Item RemoveFromEnd() {
            throw new System.NotImplementedException();
        }

        public Item RemoveFromStart() {
            throw new System.NotImplementedException();
        }

        public int Size() => _size;

        public bool IsEmpty() => _size <= 0;
    }
}
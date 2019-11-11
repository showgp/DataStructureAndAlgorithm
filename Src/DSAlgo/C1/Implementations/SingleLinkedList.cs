using C1.Interfaces;

namespace C1.Implementations {
    public class SingleLinkedList<Item> : ISingleLinkedList<Item> {
        public ISingleLinkedListNode<Item> First => _first;
        private ISingleLinkedListNode<Item> _first;

        public ISingleLinkedListNode<Item> Last => _last;
        private ISingleLinkedListNode<Item> _last;

        public ISingleLinkedListNode<Item> Head => _head;
        private ISingleLinkedListNode<Item> _head;

        public SingleLinkedList() {
            _head = new SingleLinkedListNode<Item>(default, null);
            _last = _first = null;
        }

        public void InsertAtEnd(Item item) {
            throw new System.NotImplementedException();
        }

        public void InsertAtStart(Item item) {
            throw new System.NotImplementedException();
        }

        public Item RemoveFromEnd() {
            throw new System.NotImplementedException();
        }

        public Item RemoveFromStart() {
            throw new System.NotImplementedException();
        }

        public int Size() {
            return 0;
        }

        public bool IsEmpty() {
            return true;
        }
    }
}
namespace C1 {
    public class SingleLinkedList<Item> : ILinkedList<Item> {
        /// <summary>
        /// 头指针
        /// </summary>
        private SingleLinkNode<Item> _first;

        /// <summary>
        /// 尾指针
        /// </summary>
        private SingleLinkNode<Item> _last;

        public SingleLinkedList() {
            // 附加头结点
            _first = new SingleLinkNode<Item>(default, null);
            _last = _first;
        }

        public void InsertAtStart(Item item) {
            var node = new SingleLinkNode<Item>(item, _first);
            _first = node;
        }

        public void InsertAtEnd(Item item) {
            var node = new SingleLinkNode<Item>(item, null);
            _last.Next = node;
            _last = node;
        }

        public Item RemoveFromStart() {
            var node = _first.Next;
            _first.Next = node.Next;
            if (_first.Next == null) _last = _first;
            return node.Value;
        }

        public Item RemoveFromEnd() {
            var node = _last;
            _last = FindLastPre();
            return node.Value;
        }

        private SingleLinkNode<Item> FindLastPre() {
            if (_last == _first) return _first;
            var node = _first.Next;
            while (node.Next != _last) {
                node = node.Next;
            }
            return node;
        }
    }

    public class SingleLinkNode<T> {
        /// <summary>
        /// 下一个节点指针
        /// </summary>
        /// <value></value>
        public SingleLinkNode<T> Next {
            set {
                _next = value;
            }
            get => _next;
        }
        private SingleLinkNode<T> _next;

        /// <summary>
        /// 节点元素值
        /// </summary>
        /// <value></value>
        public T Value {
            set {
                _value = value;
            }
            get => _value;
        }
        private T _value;

        public SingleLinkNode(T value, SingleLinkNode<T> next) {
            this._value = value;
            this._next = next;
        }
    }
}
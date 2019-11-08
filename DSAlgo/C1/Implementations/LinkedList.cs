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

        public void InsertAtBeginning(Item item) {
            var node = new SingleLinkNode<Item>(item, _first);
            _first = node;
        }

        public void InsertAtEnd(Item item) {
            var node = new SingleLinkNode<Item>(item, null);
            _last.Next = node;
            _last = node;
        }

        public Item RemoveFromBeginning() {
            throw new System.NotImplementedException();
        }

        public Item RemoveFromEnd() {
            throw new System.NotImplementedException();
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
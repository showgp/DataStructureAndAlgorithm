using System.Collections;
using System.Collections.Generic;
using C1.Interfaces;

namespace C1.Implementations {

    public class SingleLinkedList<Item>: ISingleLinkedList<Item> {
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
            if(_last == _head) { // 空表插入的情况
                _last = node;
            }
        }

        public Item RemoveFromEnd() {
            if(IsEmpty())
                return default;
            var preLast = _head;
            while(preLast.Next != _last) {// 寻找 Last 的前一个结点
                preLast = preLast.Next;
            }
            var value = _last.Value;
            _last = preLast;
            _last.Next = null;
            _size--;
            return value;
        }

        public Item RemoveFromStart() {
            if(IsEmpty())
                return default;
            var node = _head.Next;
            _head.Next = node.Next;
            _size--;
            if(_size == 0) {
                _last = _head;
            }
            return node.Value;
        }

        public int Size() => _size;

        public bool IsEmpty() => _size == 0;

        public IEnumerator<Item> GetEnumerator() => new SingleLinkedListEnumerator<Item>(this);

        IEnumerator IEnumerable.GetEnumerator() => new SingleLinkedListEnumerator<Item>(this);
    }

    internal class SingleLinkedListEnumerator<Item>: IEnumerator<Item> {
        public Item Current => _currenNode.Value;

        object IEnumerator.Current => _currenNode.Value;

        private SingleLinkedList<Item> _list;

        private ISingleLinkedListNode<Item> _currenNode;

        public SingleLinkedListEnumerator(SingleLinkedList<Item> list) {
            _list = list;
            _currenNode = _list.Head.Next;
        }

        public void Dispose() {
            _currenNode = null;
            _list = null;
        }

        public bool MoveNext() {
            if(_currenNode.Next != null) {
                _currenNode = _currenNode.Next;
                return true;
            }
            return false;
        }

        public void Reset() {
            _currenNode = _list.Head.Next;
        }
    }
}
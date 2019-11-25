using System.Collections;
using System.Collections.Generic;

using C1.Interfaces;

namespace C1.Implementations {

    public class LinkedStack<Item>: ILinkedStack<Item> {
        private readonly ISingleLinkedList<Item> _list;

        public LinkedStack() {
            _list = new SingleLinkedList<Item>();
        }

        public bool IsEmpty() => _list.IsEmpty();

        public Item Pop() => _list.RemoveFromStart();

        public void Push(Item item) => _list.InsertAtStart(item);

        public int Size() => _list.Size();

        public Item Top {
            get {
                if(_list.Head.Next == null)
                    return default;
                return _list.Head.Next.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();

        public IEnumerator<Item> GetEnumerator() => _list.GetEnumerator();
    }
}
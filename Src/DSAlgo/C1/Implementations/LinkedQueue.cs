using System.Collections;
using System.Collections.Generic;

using C1.Interfaces;

namespace C1.Implementations {

    public class LinkedQueue<Item>: ILinkedQueue<Item> {
        private readonly ISingleLinkedList<Item> _list;

        public LinkedQueue() {
            _list = new SingleLinkedList<Item>();
        }

        public Item Front {
            get {
                if(_list.Head.Next == null)
                    return default;
                return _list.Head.Next.Value;
            }
        }

        public Item Dequeue() => _list.RemoveFromStart();

        public void Enqueue(Item item) => _list.InsertAtEnd(item);

        public bool IsEmpty() => _list.IsEmpty();

        public int Size() => _list.Size();

        public IEnumerator<Item> GetEnumerator() => _list.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using C1.Interfaces;

namespace C1.Implementations {

    public class LinkedQueue<Item>: ILinkedQueue<Item> {
        private ISingleLinkedList<Item> _list;

        public LinkedQueue() {
            _list = new SingleLinkedList<Item>();
        }

        public Item Dequeue() {
            throw new NotImplementedException();
        }

        public void Enqueue(Item item) {
            throw new NotImplementedException();
        }

        public IEnumerator<Item> GetEnumerator() {
            throw new NotImplementedException();
        }

        public bool IsEmpty() {
            throw new NotImplementedException();
        }

        public int Size() {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            throw new NotImplementedException();
        }
    }
}
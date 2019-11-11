using System.Collections.Generic;

namespace C1 {
    public interface IBag<Item> : IEnumerable<Item> {
        /// add an item
        void Add(Item item);

        /// returns true if the bag is empty
        bool IsEmpty();

        /// return size of the bag.
        int Size();
    }

    public interface IQueue<Item> : IEnumerable<Item> {
        /// add an item
        void Enqueue(Item item);

        /// remove the least recently added item
        Item Dequeue();

        /// return true if the queue is empty
        bool IsEmpty();

        int Size();
    }

    public interface IStack<Item> : IEnumerable<Item> {
        void Push(Item item);

        Item Pop();

        bool IsEmpty();

        int Size();
    }
}
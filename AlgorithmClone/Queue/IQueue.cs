using System;

namespace AlgorithmClone.Queue {
    public interface IQueue<T> {
        /// <summary>
        /// Returns true if there's no element in the queue.
        /// </summary>
        Boolean IsEmpty { get; }

        /// <summary>
        /// Returns the size of this queue.
        /// </summary>
        /// <value></value>
        Int64 Size { get; }

        /// <summary>
        /// Returns the elements count of the queue.
        /// </summary>
        Int64 Count { get; }

        /// <summary>
        /// Returns the front element of the queue.
        /// </summary>
        T Front { get; }

        /// <summary>
        /// Add an element into the queue.
        /// </summary>
        /// <param name="value">The element to be added into the queue.</param>
        void Enqueue(T value);

        /// <summary>
        /// Remove and return the front element.
        /// </summary>
        /// <returns>Front element.</returns>
        T Dequeue();
    }
}
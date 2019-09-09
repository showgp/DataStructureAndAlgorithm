using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmClone.Stack {
    public interface IStack<T> {
        /// <summary>
        /// Returns true if Stack is empty.
        /// </summary>
        Boolean IsEmpty { get; }

        /// <summary>
        /// Returns elements count in the stack.
        /// </summary>
        Int64 Count { get; }

        /// <summary>
        /// Pushes an element into stack.
        /// </summary>
        /// <param name="value">Element to push.</param>
        void Push(T value);

        /// <summary>
        /// Pop an element out of stack.
        /// </summary>
        /// <returns>The  poped element.</returns>
        T Pop();

        /// <summary>
        /// The top element.
        /// </summary>
        T Top { get; }
    }

    public class Stack<T> : IStack<T> {

        private readonly IList<T> _elemArray;

        public Boolean IsEmpty => !_elemArray.Any();

        public Int64 Count => _elemArray.Count;

        public Stack() {
            _elemArray = new List<T>();
        }

        public void Push(T value) {
            _elemArray.Add(value);
        }

        public T Pop() {
            if (IsEmpty) {
                return default;
            } else {
                T last = _elemArray.Last();
                _elemArray.RemoveAt(_elemArray.Count - 1);
                return last;
            }
        }

        public T Top => _elemArray.Any() ? _elemArray.Last() : default;
    }
}
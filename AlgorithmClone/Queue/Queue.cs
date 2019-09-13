using System;

// TODO: 为了实现队列, 需要去探索 C# 中的数组实现, 是否在数组头部插入开销会比较大.

namespace AlgorithmClone.Queue {
    /// <summary>
    /// 普通的 Queue 实现
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    public class Queue<T> : IQueue<T> {

        private T[] _array;

        private int _size = 10;

        private int _length = 0;

        public Queue(int size) {
            _size = size;
            _array = new T[_size];
        }

        public Boolean IsEmpty => _length == 0;

        public Int64 Count => _length;

        public T Front => _length - 1 >= 0 ? _array[_length - 1] : default;

        public long Size => _size;

        public T Dequeue() {
            if (_length - 1 >= 0) {
                var elem = _array[_length - 1];
                _array[_length - 1] = default;
                _length--;
                return elem;
            }
            return default;
        }

        public void Enqueue(T value) {
            if (_length < _size) {
                _array[_length] = value;
                _length += 1;
            } else {
                _size = 2 * _size;
                var newArray = new T[_size];
                for (int i = 0; i < _length; ++i) {
                    newArray[i] = _array[i];
                }
                _array = newArray;
            }
        }
    }

    /// <summary>
    /// 针对存储空间优化的队列实现: 即在出队的时候标记该位置未被占用. 这样把出队的开销降低.
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    public class QueueOptimized<T> : IQueue<T> {
        public Boolean IsEmpty =>
        throw new NotImplementedException();

        public Int64 Count =>
        throw new NotImplementedException();

        public T Front =>
        throw new NotImplementedException();

        public long Size =>
        throw new NotImplementedException();

        public T Dequeue() {
            throw new NotImplementedException();
        }

        public void Enqueue(T vlaue) {
            throw new NotImplementedException();
        }
    }
}
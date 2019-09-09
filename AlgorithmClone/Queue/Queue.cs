using System;

// TODO: 为了实现队列, 需要去探索 C# 中的数组实现, 是否在数组头部插入开销会比较大.

namespace AlgorithmClone.Queue {
    /// <summary>
    /// 普通的 Queue 实现
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    public class Queue<T> : IQueue<T> {
        public Boolean IsEmpty =>
        throw new System.NotImplementedException();

        public Int64 Count =>
        throw new System.NotImplementedException();

        public T Front =>
        throw new System.NotImplementedException();

        public T Dequeue() {
            throw new System.NotImplementedException();
        }

        public void Enqueue(T vlaue) {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// 针对存储空间优化的队列实现.
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    public class QueueOptimized<T> : IQueue<T> {
        public Boolean IsEmpty =>
        throw new NotImplementedException();

        public Int64 Count =>
        throw new NotImplementedException();

        public T Front =>
        throw new NotImplementedException();

        public T Dequeue() {
            throw new NotImplementedException();
        }

        public void Enqueue(T vlaue) {
            throw new NotImplementedException();
        }
    }
}
using System;

using AlgorithmClone.Queue;

using Xunit;

namespace AlgorithmCloneUnitTests.QueueTests {
    public class QueueTests : IDisposable {
        private IQueue<String> _queue;

        private readonly int _initialSize = 2;

        public QueueTests() {
            _queue = new Queue<String>(_initialSize);
        }

        public void Dispose() {
            _queue = null;
        }

        [Fact]
        public void TestQueueInitialization() {
            Assert.Equal(_initialSize, _queue.Size);
            Assert.True(_queue.IsEmpty);
            Assert.Equal(0, _queue.Count);
            Assert.Null(_queue.Front);
        }

        [Fact]
        public void TestEnqueueOneElement() {
            var element = "Hello";
            // when
            _queue.Enqueue(element);
            // then
            Assert.Equal(element, _queue.Front);
            Assert.Equal(_initialSize, _queue.Size);
            Assert.Equal(1, _queue.Count);
            Assert.False(_queue.IsEmpty);
            // when
            var result = _queue.Dequeue();
            // then
            Assert.Equal(element, result);
            Assert.True(_queue.IsEmpty);
            Assert.Equal(0, _queue.Count);
            Assert.Equal(_initialSize, _queue.Size);
            Assert.Null(_queue.Front);
        }
    }
}
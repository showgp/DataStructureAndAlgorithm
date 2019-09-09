using System;

using AlgorithmClone.Stack;

using Xunit;

namespace AlgorithmCloneUnitTests.StackTests {
    public class StackTests : IDisposable {

        private IStack<String> _stack;

        public StackTests() {
            _stack = new Stack<String>();
        }
        public void Dispose() {
            _stack = null;
        }

        [Fact]
        public void TestStackIsEmpty() {
            Assert.True(_stack.IsEmpty);
            // Assert.Null(_stack.Top);
            Assert.Equal(0, _stack.Count);
            Assert.Null(_stack.Pop());
        }

        [Theory]
        [InlineData("Hello")]
        [InlineData("world")]
        public void TestOneElement(String value) {
            _stack.Push(value);
            Assert.False(_stack.IsEmpty);
            Assert.Equal(1, _stack.Count);
            Assert.Equal(value, _stack.Top);

            String result = _stack.Pop();
            Assert.Equal(result, value);
            Assert.True(_stack.IsEmpty);
            Assert.Equal(0, _stack.Count);
            // Assert.Null(_stack.Top);
        }

        [Fact]
        public void TestTwoElements() {
            _stack.Push("Hello");
            _stack.Push("World");
            Assert.False(_stack.IsEmpty);
            Assert.Equal(2, _stack.Count);
            Assert.Equal("World", _stack.Top);

            String world = _stack.Pop();
            Assert.Equal(1, _stack.Count);
            Assert.Equal("Hello", _stack.Top);
            Assert.False(_stack.IsEmpty);
            Assert.Equal("World", world);

            String hello = _stack.Pop();
            Assert.Equal(0, _stack.Count);
            Assert.True(_stack.IsEmpty);
            Assert.Equal("Hello", hello);
            Assert.Null(_stack.Pop());
        }
    }
}
using System;

using C1.Implementations;
using C1.Interfaces;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAlgo.Tests {

    [TestClass]
    public class LinkedQueueTests {
        private ILinkedQueue<String> _sut;

        /*
         *   void Enqueue(Item item);
         *   Item Dequeue();
         *   bool IsEmpty();
         *   int Size();
         */

        [TestInitialize]
        public void Setup() {
            _sut = new LinkedQueue<string>();
        }

        [TestCleanup]
        public void Teardown() {
            _sut = null;
        }

        [TestMethod]
        public void TestEnqueue() {
            var elem1 = "elem1";
            var elem2 = "elem2";
            _sut.Enqueue(elem1);
            Assert.AreEqual(elem1, _sut.Front);
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            _sut.Enqueue(elem2);
            Assert.AreEqual(elem1, _sut.Front);
            Assert.AreEqual(2, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
        }

        [TestMethod]
        public void TestDequeue() {
            var elem1 = "elem1";
            var elem2 = "elem2";
            _sut.Enqueue(elem1);
            _sut.Enqueue(elem2);
            Assert.AreEqual(elem1, _sut.Front);
            Assert.AreEqual(2, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            var r1 = _sut.Dequeue();
            Assert.AreEqual(elem1, r1);
            Assert.AreEqual(elem2, _sut.Front);
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            var r2 = _sut.Dequeue();
            Assert.AreEqual(elem2, r2);
            Assert.AreEqual(null, _sut.Front);
            Assert.AreEqual(0, _sut.Size());
            Assert.IsTrue(_sut.IsEmpty());
            var r3 = _sut.Dequeue();
            Assert.AreEqual(null, r3);
            Assert.IsTrue(_sut.IsEmpty());
        }
    }
}
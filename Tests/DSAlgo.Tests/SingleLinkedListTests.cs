using C1.Implementations;
using C1.Interfaces;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAlgo.Tests {
    [TestClass]
    public class SingleLinkedListTests {

        SingleLinkedList<string> _sut;

        [TestInitialize]
        public void Setup() {
            _sut = new SingleLinkedList<string>();
        }

        [TestCleanup]
        public void Teardown() {
            _sut = null;
        }

        // TODO: 探索如何进行泛型测试, 比如指定泛型参数和参数值, 这样就可以避免重复写.

        /*
        测试:
        1. 构造 √
        1. 头部插入 √
        1. 头部删除 √
        1. 尾部插入 √
        1. 尾部删除 √
        1. 是否为空 √
        1. 元素个数 √
        */

        [TestMethod]
        public void TestInitialization() {
            ISingleLinkedList<int> list = new SingleLinkedList<int>();
            Assert.IsTrue(list.IsEmpty());
            Assert.IsNull(list.Head.Next);
            Assert.AreEqual(0, list.Size());
            Assert.IsNotNull(list.Head);
        }

        [TestMethod]
        public void TestInsertAtStart() {
            // given
            var elem = "Hello World";
            // when
            _sut.InsertAtStart(elem);
            // then
            Assert.IsNotNull(_sut.Head.Next);
            Assert.IsNull(_sut.Head.Next.Next);
            Assert.AreEqual(elem, _sut.Head.Next.Value);
            Assert.IsFalse(_sut.IsEmpty());
            Assert.AreEqual(1, _sut.Size());
            Assert.IsNotNull(_sut.Last);
            Assert.AreEqual(_sut.Head.Next, _sut.Last);
        }

        [TestMethod]
        public void TestDeletionAtStart() {
            var elem1 = "hello1";
            var elem2 = "world2";
            _sut.InsertAtStart(elem1);
            _sut.InsertAtStart(elem2);

            Assert.IsFalse(_sut.IsEmpty());
            Assert.AreEqual(2, _sut.Size());
            Assert.AreEqual(elem2, _sut.Head.Next.Value);
            Assert.AreEqual(elem1, _sut.Head.Next.Next.Value);
            Assert.IsNull(_sut.Head.Next.Next.Next);

            var r1 = _sut.RemoveFromStart();
            Assert.AreEqual(elem2, r1);
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            var r2 = _sut.RemoveFromStart();
            Assert.AreEqual(elem1, r2);
            Assert.AreEqual(0, _sut.Size());
            Assert.IsTrue(_sut.IsEmpty());
            Assert.IsNull(_sut.Head.Next);
            Assert.AreEqual(_sut.Head, _sut.Last);

            var r3 = _sut.RemoveFromStart();
            Assert.IsNull(r3);
            Assert.AreEqual(0, _sut.Size());
            Assert.IsTrue(_sut.IsEmpty());
            Assert.AreEqual(_sut.Head, _sut.Last);
        }

        [TestMethod]
        public void TestInsertOneElemAtEnd() {
            var elem1 = "hello1";
            _sut.InsertAtEnd(elem1);
            Assert.AreEqual(elem1, _sut.Last.Value);
            Assert.IsNull(_sut.Last.Next);
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            Assert.AreEqual(_sut.Head.Next, _sut.Last);
        }

        [TestMethod]
        public void TestInsertMoreThanOneElemAtEnd() {
            var elem1 = "elem1";
            var elem2 = "elem2";
            var elem3 = "elem3";
            _sut.InsertAtEnd(elem1);
            _sut.InsertAtEnd(elem2);
            _sut.InsertAtEnd(elem3);
            Assert.AreEqual(3, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            Assert.AreEqual(elem1, _sut.Head.Next.Value);
            Assert.AreEqual(elem2, _sut.Head.Next.Next.Value);
            Assert.AreEqual(elem3, _sut.Head.Next.Next.Next.Value);
            Assert.AreEqual(elem3, _sut.Last.Value);
            Assert.IsNull(_sut.Last.Next);
            Assert.AreNotEqual(_sut.Last, _sut.Head.Next);
        }

        [TestMethod]
        public void TestRemoveFromEnd() {
            var elem1 = "elem1";
            var elem2 = "elem2";
            var elem3 = "elem3";
            _sut.InsertAtEnd(elem1);
            _sut.InsertAtEnd(elem2);
            _sut.InsertAtEnd(elem3);

            Assert.AreEqual(3, _sut.Size());
            Assert.AreEqual(elem1, _sut.Head.Next.Value);
            Assert.AreEqual(elem3, _sut.Last.Value);

            var r1 = _sut.RemoveFromEnd();
            Assert.AreEqual(elem3, r1);
            Assert.AreEqual(2, _sut.Size());
            Assert.AreEqual(elem2, _sut.Last.Value);

            var r2 = _sut.RemoveFromEnd();
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            Assert.AreEqual(elem2, r2);
            Assert.AreEqual(elem1, _sut.Last.Value);

            var r3 = _sut.RemoveFromEnd();
            Assert.AreEqual(0, _sut.Size());
            Assert.IsTrue(_sut.IsEmpty());
            Assert.AreEqual(elem1, r3);
            Assert.AreEqual(_sut.Head, _sut.Last);
            Assert.IsNull(_sut.Head.Next);

            var r4 = _sut.RemoveFromEnd();
            Assert.IsNull(r4);
            Assert.AreEqual(0, _sut.Size());
            Assert.AreEqual(_sut.Head, _sut.Last);
            Assert.IsTrue(_sut.IsEmpty());
        }
    }
}
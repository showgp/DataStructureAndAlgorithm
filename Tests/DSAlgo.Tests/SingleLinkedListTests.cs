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
        1. 构造
        1. 头部插入
        1. 头部删除
        1. 尾部插入
        1. 尾部删除
        1. 是否为空
        1. 元素个数
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
    }
}
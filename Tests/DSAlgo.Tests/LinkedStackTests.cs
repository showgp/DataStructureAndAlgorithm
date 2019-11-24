using C1.Implementations;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAlgo.Tests {

    [TestClass]
    public class LinkedStackTests {
        private LinkedStack<string> _sut;

        /*
         *  void Push(Item item);
         *  Item Pop();
         *  bool IsEmpty();
         *  int Size();
         */

        [TestInitialize]
        public void Setup() {
            _sut = new LinkedStack<string>();
        }

        [TestCleanup]
        public void Teardown() {
            _sut = null;
        }

        [TestMethod]
        public void TestPush() {
            var elem1 = "elem1";
            var elem2 = "elem2";

            _sut.Push(elem1);
            Assert.AreEqual(elem1, _sut.Top);

            _sut.Push(elem2);
            Assert.AreEqual(elem2, _sut.Top);
        }

        [TestMethod]
        public void TestPop() {
            var elem1 = "elem1";
            var elem2 = "elem2";

            _sut.Push(elem1);
            _sut.Push(elem2);

            var r1 = _sut.Pop();
            Assert.AreEqual(elem2, r1);
            Assert.AreEqual(elem1, _sut.Top);
            var r2 = _sut.Pop();
            Assert.AreEqual(elem1, r2);
            var r3 = _sut.Pop();
            Assert.IsNull(r3);
        }

        [TestMethod]
        public void TestSize() {
            var elem1 = "elem1";
            var elem2 = "elem2";
            Assert.IsTrue(_sut.IsEmpty());
            Assert.AreEqual(0, _sut.Size());
            _sut.Push(elem1);
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            _sut.Push(elem2);
            Assert.AreEqual(2, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            _sut.Pop();
            Assert.AreEqual(1, _sut.Size());
            Assert.IsFalse(_sut.IsEmpty());
            _sut.Pop();
            Assert.AreEqual(0, _sut.Size());
            Assert.IsTrue(_sut.IsEmpty());
            _sut.Pop();
            Assert.AreEqual(0, _sut.Size());
            Assert.IsTrue(_sut.IsEmpty());
        }
    }
}
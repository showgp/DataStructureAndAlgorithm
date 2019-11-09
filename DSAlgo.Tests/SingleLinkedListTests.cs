using C1;

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

        [TestMethod]
        public void TestListInitialization() {
            ILinkedList<string> list = new SingleLinkedList<string>();
            Assert.IsNotNull(list);
        }

        [TestMethod]
        public void TestAddItemToBeginning() {
            var value = "FirstValue";
            _sut.InsertAtStart(value);
            Assert.AreEqual(value, _sut.First.Next.Value);
            Assert.AreEqual(value, _sut.Last.Value);
        }
    }
}
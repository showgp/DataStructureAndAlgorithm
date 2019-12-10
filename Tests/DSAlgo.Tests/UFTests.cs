using System.Collections.Generic;

using C1.Interfaces.UnionFind;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAlgo.Tests {

    [TestClass]
    public class QuickFindUFTests {
        private IUnionFind sut;

        [TestInitialize]
        public void Setup() {
            sut = new QuickFindUF(10);
        }

        [TestCleanup]
        public void Teardown() {
            sut = null;
        }

        [TestMethod]
        public void TestInit() {
            var qf = new QuickFindUF(10);
            Assert.AreEqual(10, qf.Count());
        }

        public void TestFind() {
            Assert.AreEqual(8, sut.Find(8));
        }

        [TestMethod]
        public void TestUnion() {
            sut.Union(0, 1);
            Assert.AreEqual(1, sut.Find(0));
            Assert.AreEqual(9, sut.Count());
        }
    }

    [TestClass]
    public class QuickUnionWithWeightAndPathCompressTests {
        private IUnionFind _sut;
        private readonly int _count = 10;

        [TestInitialize]
        public void Setup() {
            _sut = new QuickUnionImprovementsUF(_count);
        }

        [TestCleanup]
        public void Teardown() {
            _sut = null;
        }

        [TestMethod]
        public void TestInit() {
            Assert.AreEqual(_sut.Count(), _count);
            for(int i = 0; i < _count; ++i) {
                Assert.AreEqual(i, _sut.Find(i));
            }
        }

        [TestMethod]
        public void TestUnion() {
            _sut.Union(4, 3);
            Assert.AreEqual(9, _sut.Count());
            Assert.IsTrue(_sut.IsConnected(4, 3));
            Assert.AreEqual(4, _sut.Find(3));
            Assert.AreEqual(4, _sut.Find(4));

            _sut.Union(3, 8);
            Assert.AreEqual(8, _sut.Count());
            Assert.IsTrue(_sut.IsConnected(3, 8));
            Assert.AreEqual(4, _sut.Find(3));
            Assert.AreEqual(4, _sut.Find(8));
        }
    }
}
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
}
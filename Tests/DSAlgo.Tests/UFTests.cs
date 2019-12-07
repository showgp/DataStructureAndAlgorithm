using Microsoft.VisualStudio.TestTools.UnitTesting;
using C1.Interfaces.UnionFind;
using System.Collections.Generic;

namespace DSAlgo.Tests {

    [TestClass]
    public class UFTests {

        public void TestUF() {
            // TODO: 构造所有的连接点列表
            List<PointPair> items = new List<PointPair>();
            IUnionFind uf = new UnionFindImp(items.Count);
            foreach(var point in items) {
                if(!(uf.IsConnected(point.P, point.Q))) {
                    uf.Union(point.P, point.Q);
                }
            }
        }
    }
}
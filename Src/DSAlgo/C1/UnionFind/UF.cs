using System.Collections.Generic;

namespace C1.Interfaces.UnionFind {

    /// <summary>
    /// 动态连通性问题算法接口.
    ///
    /// 其中给定 N 个节点, 我们首先得到了 N 个 Component, 每一次的 union 操作都会把 Component 的个数减一.
    /// </summary>
    public interface IUnionFind {

        /// <summary>
        /// 把两个节点连通. 即如果两个节点不连通(不在同一个连通分量中), 则将二者放入同一个连通分量中.
        /// </summary>
        /// <param name="p">节点 p 的编号</param>
        /// <param name="q">节点 q 的编号</param>
        void Union(int p, int q);

        /// <summary>
        /// 找到节点 p 所在连通分量(compoment)的编号.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>p 所在连通分量的编号</returns>
        int Find(int p);

        /// <summary>
        /// 判断两个节点是否连通. 即判断两个节点是否位于同一个连通分量(compoment)中
        /// </summary>
        /// <param name="p">p 节点编号</param>
        /// <param name="q">q 节点编号</param>
        /// <returns>若p和q连通, 则返回 true</returns>
        bool IsConnected(int p, int q);

        /// <summary>
        /// 当前连通分量总个数.
        /// </summary>
        /// <returns>连通分量个数</returns>
        int Count();
    }

    /// <summary>
    /// 动态连通性问题的 QuickFind 算法实现类. 主要目的是实现快速查找, 但 Union 操作开销大.
    /// </summary>
    public class QuickFindUF : IUnionFind {
        private readonly int[] id;

        public QuickFindUF(int numberOfItems) {
            id = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; ++i) id[i] = i;
        }

        public int Count() {
            var set = new HashSet<int>(id);
            return set.Count;
        }

        public int Find(int p) => id[p];

        public bool IsConnected(int p, int q) => id[p] == id[q];

        public void Union(int p, int q) {
            // 1 找出 p 的值, q 的值
            var pID = id[p];
            var qID = id[q];
            // 将数组中所有等于 pID 的值修改为 qID
            for (int i = 0; i < id.Length; ++i)
                if (id[i] == pID) id[i] = qID;
        }
    }

    public class QuickUnionUF : IUnionFind {
        private readonly int[] id;

        public QuickUnionUF(int numberOfItems) {
            id = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; ++i) id[i] = i;
        }

        public int Count() {
            throw new System.NotImplementedException();
        }

        public int Find(int p) => FindRootOf(p);

        // 是否满足性能需求, 还是有提高空间?
        public bool IsConnected(int p, int q) => FindRootOf(p) == FindRootOf(q);

        public void Union(int p, int q) {
            // p.root.parent = q.root
            // 1. find q's root
            // 2. find p's root
            // 3. set p's root's parent as q's root

            // if (IsConnected(p, q)) return;

            var pRoot = FindRootOf(p);
            var qRoot = FindRootOf(q);
            id[pRoot] = qRoot;
        }

        /// 找到 p 的 root 下标
        private int FindRootOf(int p) {
            var root = p;
            // 当下标和值不相等时, 说明还没有到根, 此时将 root 下标往上设置.
            while (root != id[root]) root = id[root];
            return root;
        }
    }
}
namespace C1.Interfaces.UnionFind {

    /// <summary>
    /// 动态连通性问题算法接口.
    ///
    /// 其中给定 N 个节点, 我们首先得到了 N 个 Component, 每一次的 union 操作都会把 Component 的个数减一.
    /// </summary>
    public interface IUnionFind {

        /// <summary>
        /// 把两个节点间添加连通. 即如果两个节点不连通(不在同一个组件中), 则将两个节点所在的组件进行合并.
        /// </summary>
        /// <param name="p">节点 p 的编号</param>
        /// <param name="q">节点 q 的编号</param>
        void Union(int p, int q);

        /// <summary>
        /// 找到节点 p 所在组件(compoment)的编号.
        ///
        /// 组件是一个集合, 在集合内的所有节点都是连通的, 组件自身也有编号.(可能范围是 0 到 N - 1, 0 表示空集合的情况, N - 1表示所有点都不连通)
        /// </summary>
        /// <param name="p"></param>
        /// <returns>p 所在组件的编号</returns>
        int Find(int p);

        /// <summary>
        /// 判断两个节点是否连通. 即判断两个节点是否位于同一个组件(compoment)中
        /// </summary>
        /// <param name="p">p 节点编号</param>
        /// <param name="q">q 节点编号</param>
        /// <returns>若p和q连通, 则返回 true</returns>
        bool IsConnected(int p, int q);

        /// <summary>
        /// 当前数据情况下的组件总个数.
        /// </summary>
        /// <returns>组件个数</returns>
        int Count();
    }

    public class UnionFindImp: IUnionFind {

        public UnionFindImp(int numberOfPoints) {
        }

        public int Count() {
            throw new System.NotImplementedException();
        }

        public int Find(int p) {
            throw new System.NotImplementedException();
        }

        public bool IsConnected(int p, int q) {
            throw new System.NotImplementedException();
        }

        public void Union(int p, int q) {
            throw new System.NotImplementedException();
        }
    }

    public struct PointPair {
        public int P { get; }
        public int Q { get; }

        public PointPair(int p, int q) {
            P = p;
            Q = q;
        }
    }
}
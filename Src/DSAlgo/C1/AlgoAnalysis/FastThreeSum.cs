using System;

namespace C1.AlgoAnalysis {
    public class FastThreeSum {
        public static UInt64 Count(int[] a) {
            // 排序
            Array.Sort(a);
            UInt64 count = 0;
            for (int i = 0; i < a.Length; ++i) {
                for (int j = i + 1; j < a.Length; ++j)
                    if (Array.BinarySearch(a, -(a[i] + a[j])) > j) count++;
            }
            return count;
        }
    }
}
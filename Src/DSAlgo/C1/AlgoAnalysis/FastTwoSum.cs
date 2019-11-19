using System;
using System.Collections;

namespace C1.AlgoAnalysis {
    public class FastTwoSum {
        public static UInt64 Count(int[] a) {
            // 排序
            Array.Sort(a);
            UInt64 count = 0;
            for (int i = 0; i < a.Length; ++i) {
                if (Array.BinarySearch(a, -a[i]) > i) count++;
            }
            return count;
        }
    }
}
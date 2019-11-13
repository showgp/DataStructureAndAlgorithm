using System;

namespace C1.AlgoAnalysis {
    public class ThreeSum {
        public static int Count(int[] a) {
            int N = a.Length;
            int cnt = 0;
            for (int i = 0; i < N; i++)
                for (int j = i + 1; j < N; j++)
                    for (int k = j + 1; k < N; k++)
                        if (a[i] + a[j] + a[k] == 0) cnt++;
            return cnt;
        }

        public static int[] GetRandomArray(string[] args) {
            int count = int.Parse(args[0]);
            int[] a = new int[count];
            for (int i = 0; i < count; i++)
                a[i] = new Random().Next(-1000000, 1000000);
            return a;
        }
    }
}
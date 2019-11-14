using System;
using System.Diagnostics;

using C1.AlgoAnalysis;
using C1.Implementations;

namespace DSAlgo {
    class Program {
        public static void Main(string[] args) {
            double a = 1444.2539000000002 / Math.Pow(1280, 3);
            double r = a * Math.Pow(2560, 3);
            System.Console.WriteLine(r);
            ThreeSumCalc(args);
        }

        /// <summary>
        /// 算法分析的入门例子客户代码
        /// </summary>
        /// <param name="args"></param>
        private static void ThreeSumCalc(string[] args) {
            if (args.Length == 0) {
                System.Console.WriteLine("需要在参数中指定问题规模! \n放弃计算...");
                return;
            }
            int count = int.Parse(args[0]);
            for (int i = 1; i <= 5; i++) {
                int size = count * Convert.ToInt32(Math.Pow(2, i));
                ThreeSumCalc(size);
            }
        }

        private static void ThreeSumCalc(int count) {
            var arr = ThreeSum.GetRandomArray(count);
            var watch = new Stopwatch();
            watch.Start();
            var result = ThreeSum.Count(arr);
            watch.Stop();
            var ts = watch.Elapsed;

            System.Console.WriteLine();
            System.Console.WriteLine($"消耗时间: {ts.TotalMilliseconds} ms ({ts.TotalSeconds} s)");
            System.Console.WriteLine($"问题规模: {arr.Length}");
            System.Console.WriteLine($"求解结果(三个数和为 0 的个数): {result}");
            System.Console.WriteLine();
        }

        private static void OldMain() {
            char[] a = new char[3];
            a[0] = 'a';
            System.Console.WriteLine(a[0]);
            System.Console.WriteLine("Hello");
            IShortAlgos algoProvider = new ShortAlgos();
            uint result = algoProvider.GCD(8, 4);
            System.Console.WriteLine($"8 和 4 的最大公约数是: {result}");
            System.Console.WriteLine("C1 的定长 stack: ");
            FixedCapacityStackClient();
            System.Console.WriteLine(">-----------------------<");
            LinkedListStackClient();
        }

        /// <summary>
        /// 定长 Stack 的一个应用: 倒序输出某个序列
        /// </summary>
        static void FixedCapacityStackClient() {
            var arr = new String[] { "h1", "h2", "h3", "h4", "h5" };
            var stack = new FixedCapacityStack<String>(arr.Length);
            foreach (var item in arr) {
                stack.Push(item);
            }
            // 实现了迭代器之后, 就可以直接在 stack 上遍历了(这里实现的是一个逆序迭代器)
            foreach (var item in stack) {
                System.Console.WriteLine($"栈中元素: {item}");
            }
            while (!stack.IsEmpty()) {
                System.Console.WriteLine(stack.Pop());
            }
        }

        /// <summary>
        /// 链式栈的客户代码
        /// </summary>
        static void LinkedListStackClient() { }
    }
}
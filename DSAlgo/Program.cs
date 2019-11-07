using System;

using C1;

namespace DSAlgo {
    class Program {
        public static void Main() {
            char[] a = new char[3];
            a[0] = 'a';
            System.Console.WriteLine(a[0]);
            System.Console.WriteLine("Hello");
            IShortAlgos algoProvider = new ShortAlgos();
            uint result = algoProvider.GCD(8, 4);
            System.Console.WriteLine($"8 和 4 的最大公约数是: {result}");
            System.Console.WriteLine("C1 的定长 stack: ");
            FixedCapacityStackClient();
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
            while (!stack.IsEmpty()) {
                System.Console.WriteLine(stack.Pop());
            }
        }
    }
}
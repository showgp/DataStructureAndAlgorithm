using System;

namespace CSharpDemoA {
    class Program {
        public static void Main() {
            System.Console.WriteLine("Hello");
            System.Console.WriteLine($"8 和 4 的最大公约数是: {GCD(8, 4)}");
        }

        /// <summary>
        /// 求两个数的最大公约数.
        /// 
        /// 两个输入中, p ≥ q, 且两个都为正数.
        /// 
        /// 算法描述如下:
        /// 
        /// 1. 如果 q == 0, 则结果为 p.
        /// 
        /// 1. 如果 q != 0, 则结果为 q 和 (p % q) 的最大公约数.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="q"></param>
        /// <returns>p 和 q 的最大公约数.</returns>
        private static uint GCD(uint p, uint q) {
            if (q == 0) { return p; }
            return GCD(q, p % q);
        }
    }
}
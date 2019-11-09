using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DSAlgo.Tests {
    [TestClass]
    public class UnitTest1 {
        private static TestContext _context;

        private static int count = 0;

        private int _testMethod = 0;

        [TestMethod]
        public void TestMethod1() {
            Assert.IsNotNull(_context);
            Assert.AreEqual(count, 1);
            Assert.AreEqual(_testMethod, 2);
            _testMethod = 3;
        }

        [TestMethod]
        public void TestMethod2() {
            Assert.IsNotNull(_context.ToString());
            Assert.AreEqual(count, 1);
            Assert.AreEqual(_testMethod, 2);
            _testMethod = 3;
        }

        [AssemblyInitialize]
        public static void AI1(TestContext context) {
            _context = context;
        }

        [AssemblyCleanup]
        public static void AI2() {
            _context = null;
        }

        [ClassInitialize]
        public static void CI1(TestContext _) {
            count = 1;
        }

        [ClassCleanup]
        public static void CI2() {
            count = 0;
        }

        [TestInitialize]
        public void TI1() {
            _testMethod = 2;
        }

        [TestCleanup]
        public void TI2() {
            _testMethod = 0;
        }
    }
}
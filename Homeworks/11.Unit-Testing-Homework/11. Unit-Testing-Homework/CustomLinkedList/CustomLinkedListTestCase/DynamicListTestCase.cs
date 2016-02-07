using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomLinkedList;

namespace CustomLinkedListTestCase
{
    [TestClass]
    public abstract class DynamicListTestCase
    {
        private readonly string ValueA = "A";
        private readonly string ValueB = "B";
        private readonly string ValueC = "C";
        private readonly string ValueD = "D";
        private DynamicList<string> list;

        protected abstract DynamicList<string> GetList();

        [ClassInitialize]
        public static void ClassInit(TestContext context)
        {
            
        }

        [TestInitialize]
        public void Init()
        {
            this.list = GetList();
        }

        [TestCleanup]
        public void CleanUp()
        {
            this.list = null;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestInsertIntoNegativeIndexThrowsException()
        {
            
        }
    }
}

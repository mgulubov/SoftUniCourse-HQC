
using System;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTestCase
{
    [TestClass]
    public class ConcreteListTestCase : DynamicListTestCase
    {
        [ClassInitialize]
        public static void Init(TestContext context)
        {
            ClassInit(context);
        }

        protected override DynamicList<string> GetList()
        {
            return new DynamicList<string>();
        }
    }
}

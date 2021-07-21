using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListReimplimentation
{
    [TestFixture]
    public class SinglyLinkedListTest
    {
        [Test]
        public void CreateEmptyList_CorrectState()
        {
            var list = new SinglyLinkedList<int>();
            Assert.IsTrue(list.isEmpty);
            Assert.IsNull(list.Head);
            Assert.IsNull(list.Tail);

        }

    }

}

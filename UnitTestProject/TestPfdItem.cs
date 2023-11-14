using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class TestPfdItem
    {
        [TestMethod]
        public void TestMethod_PfdItem_Constructor_01()
        {
            PFD_Editor.PfdItem pfdItem = new PFD_Editor.PfdItem();
            Assert.AreEqual(0, pfdItem.id);
            Assert.AreEqual("", pfdItem.subject);
            Assert.AreEqual("", pfdItem.description);
            Assert.AreEqual(PfdItem.PfdItemType.WorkProduct, pfdItem.type);
        }


        [TestMethod]
        public void TestMethod_PfdItem_Constructor_02()
        {
            PFD_Editor.PfdItem pfdItem = new PfdItem(1);
            Assert.AreEqual(1, pfdItem.id);
            Assert.AreEqual("", pfdItem.subject);
            Assert.AreEqual("", pfdItem.description);
            Assert.AreEqual(PfdItem.PfdItemType.WorkProduct, pfdItem.type);
        }
    }
}

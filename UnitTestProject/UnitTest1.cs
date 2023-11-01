using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PFD_Editor.PfdItem pfdItem = new PFD_Editor.PfdItem();
            Assert.AreEqual(0, pfdItem.id);
            Assert.AreEqual("", pfdItem.subject);
            Assert.AreEqual("", pfdItem.description);
            Assert.AreEqual(PfdItem.PfdItemType.WorkProduct, pfdItem.type);
        }

        [TestMethod]
        public void TestMethod2()
        {
            PFD_Editor.PfdProcess pfdProcess = new PFD_Editor.PfdProcess();
            Assert.AreEqual(0, pfdProcess.id);
            Assert.AreEqual("", pfdProcess.subject);
            Assert.AreEqual("", pfdProcess.description);
            Assert.AreEqual(PfdItem.PfdItemType.Process, pfdProcess.type);
        }

        [TestMethod]
        public void TestMethod3()
        {
            PFD_Editor.PfdWorkProduct pfdWorkProduct = new PFD_Editor.PfdWorkProduct();
            Assert.AreEqual(0, pfdWorkProduct.id);
            Assert.AreEqual("", pfdWorkProduct.subject);
            Assert.AreEqual("", pfdWorkProduct.description);
            Assert.AreEqual(PfdItem.PfdItemType.WorkProduct, pfdWorkProduct.type);
        }
    }
}

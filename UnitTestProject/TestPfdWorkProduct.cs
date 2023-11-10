using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestPfdWorkProduct
    {
        [TestMethod]
        public void TestMethod_PfdWorkProduct_Constructor_01()
        {
            PFD_Editor.PfdWorkProduct pfdWorkProduct = new PFD_Editor.PfdWorkProduct();
            Assert.AreEqual(0, pfdWorkProduct.id);
            Assert.AreEqual("", pfdWorkProduct.subject);
            Assert.AreEqual("", pfdWorkProduct.description);
            Assert.AreEqual(PfdItem.PfdItemType.WorkProduct, pfdWorkProduct.type);
        }

        [TestMethod]
        public void TestMethod_PfdWorkProduct_Constructor_02()
        {
            PFD_Editor.PfdWorkProduct pfdWorkProductOriginal = new PFD_Editor.PfdWorkProduct();
            pfdWorkProductOriginal.id = 1;
            pfdWorkProductOriginal.subject = "aaa";
            pfdWorkProductOriginal.description = "bbb";
            PFD_Editor.PfdWorkProduct pfdWorkProduct = new PFD_Editor.PfdWorkProduct(pfdWorkProductOriginal);
            Assert.AreEqual(pfdWorkProductOriginal.id, pfdWorkProduct.id);
            Assert.AreEqual(pfdWorkProductOriginal.subject, pfdWorkProduct.subject);
            Assert.AreEqual(pfdWorkProductOriginal.description, pfdWorkProduct.description);
            Assert.AreEqual(PfdItem.PfdItemType.WorkProduct, pfdWorkProduct.type);
        }
    }
}

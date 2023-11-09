using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
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

        [TestMethod]
        public void TestMethod_PfdProcess_Constructor_01()
        {
            PFD_Editor.PfdProcess pfdProcess = new PFD_Editor.PfdProcess();
            Assert.AreEqual(0, pfdProcess.id);
            Assert.AreEqual("", pfdProcess.subject);
            Assert.AreEqual("", pfdProcess.description);
            Assert.AreEqual(PfdItem.PfdItemType.Process, pfdProcess.type);
        }

        [TestMethod]
        public void TestMethod_PfdProcess_Constructor_02()
        {
            PFD_Editor.PfdProcess pfdProcessOriginal = new PFD_Editor.PfdProcess();
            pfdProcessOriginal.id = 1;
            pfdProcessOriginal.subject = "aaa";
            pfdProcessOriginal.description = "bbb";
            PFD_Editor.PfdProcess pfdProcess = new PFD_Editor.PfdProcess(pfdProcessOriginal);
            Assert.AreEqual(pfdProcessOriginal.id, pfdProcess.id);
            Assert.AreEqual(pfdProcessOriginal.subject, pfdProcess.subject);
            Assert.AreEqual(pfdProcessOriginal.description, pfdProcess.description);
            Assert.AreEqual(PfdItem.PfdItemType.Process, pfdProcess.type);
        }

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

        [TestMethod]
        public void Test_JsonFile_Sequence001()
        {
            string testFileName = "test01.json";
            string value;

            // Setup
            File.Delete(testFileName);

            // Create instance
            PFD_Editor.JsonFile jsonFile = new PFD_Editor.JsonFile(testFileName);

            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value0", value);

            jsonFile.SetString("param1", "value1");

            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value1", value);

            PFD_Editor.JsonFile jsonFile2 = new PFD_Editor.JsonFile(testFileName);

            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value1", value);

            jsonFile.Save();

            // Tear down
            File.Delete(testFileName);
        }
    }
}

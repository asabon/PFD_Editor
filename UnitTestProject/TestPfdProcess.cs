using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestPfdProcess
    {
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
    }
}

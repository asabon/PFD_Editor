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
            pfdProcessOriginal.inputIdList = new System.Collections.Generic.List<int>
            {
                1,
                2,
                3,
                4,
                5
            };
            pfdProcessOriginal.outputIdList = new System.Collections.Generic.List<int>
            {
                11,
                12,
                13,
                14,
                15
            };
            PFD_Editor.PfdProcess pfdProcess = new PFD_Editor.PfdProcess(pfdProcessOriginal);
            Assert.AreEqual(pfdProcessOriginal.id, pfdProcess.id);
            Assert.AreEqual(pfdProcessOriginal.subject, pfdProcess.subject);
            Assert.AreEqual(pfdProcessOriginal.description, pfdProcess.description);
            Assert.AreEqual(PfdItem.PfdItemType.Process, pfdProcess.type);
        }
    }
}

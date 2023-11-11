using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PFD_Editor;

namespace UnitTestProject
{
    [TestClass]
    public class TestMainForm
    {
        [TestMethod]
        public void TestMethod1()
        {
            PFD_Editor.MainForm mainForm = new PFD_Editor.MainForm();
        }
    }
}

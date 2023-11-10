using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class TestSetting
    {
        private const string settingFileName = "testSetting.ini";

        [TestMethod]
        public void TestMethod1()
        {
            PFD_Editor.Setting setting = new Setting(settingFileName);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class TestJsonFile
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Do nothing
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Do nothing
        }

        [TestMethod]
        public void Test_Constructor()
        {
            PFD_Editor.JsonFile jsonFile = new JsonFile("sample.json");
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

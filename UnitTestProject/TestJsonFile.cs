using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
using System;
using System.IO;

namespace UnitTestProject
{
    [TestClass]
    public class TestJsonFile
    {
        private string testJsonFile = "sample.json";

        [TestInitialize]
        public void TestInitialize()
        {
            // Setup
            File.Delete(testJsonFile);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            File.Delete(testJsonFile);
        }

        [TestMethod]
        public void Test_Constructor()
        {
            PFD_Editor.JsonFile jsonFile = new JsonFile(testJsonFile);
            Assert.AreNotEqual(null, jsonFile);
        }

        [TestMethod]
        public void Test_Save_001()
        {
        }

        [TestMethod]
        public void Test_Load_001()
        {
        }

        [TestMethod]
        public void Test_GetString_001()
        {
            string value;
            PFD_Editor.JsonFile jsonFile = new PFD_Editor.JsonFile(testJsonFile);

            // GetString() from empty parameter.
            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value0", value);
        }

        [TestMethod]
        public void Test_GetString_002()
        {
            string value;
            PFD_Editor.JsonFile jsonFile = new PFD_Editor.JsonFile(testJsonFile);
            jsonFile.SetString("param1", "value1");

            // GetString() from exist(param1 = value1) parameter.
            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value1", value);
        }

        [TestMethod]
        public void Test_SetString_001()
        {
            string value;
            PFD_Editor.JsonFile jsonFile = new PFD_Editor.JsonFile(testJsonFile);
            jsonFile.SetString("param1", "value2");

            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value2", value);
        }
    }
}

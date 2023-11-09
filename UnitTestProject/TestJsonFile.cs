using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class TestJsonFile
    {
        [TestMethod]
        public void TestMethod_Constructor()
        {
            PFD_Editor.JsonFile jsonFile = new PFD_Editor.JsonFile("sample.json");
            string value;
            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value0", value);

            jsonFile.SetString("param1", "value1");
            value = jsonFile.GetString("param1", "value0");
            Assert.AreEqual("value1", value);
        }
    }
}

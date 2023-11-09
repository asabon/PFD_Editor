using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFD_Editor;
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
        public void Test_Constructor()
        {
            PFD_Editor.JsonFile jsonFile = new JsonFile("sample.json");
        }
    }
}

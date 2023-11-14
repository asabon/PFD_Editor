using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PFD_Editor;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class TestPfdProcessEditor
    {
        [TestMethod]
        public void Test_SetItem_001()
        {
            PFD_Editor.PfdProcessEditor editor = new PfdProcessEditor();
            PFD_Editor.PfdProcess item = new PfdProcess();
            List<PfdWorkProduct> workProducts = new List<PfdWorkProduct>();
            PfdWorkProduct workProduct01 = new PfdWorkProduct();
            workProduct01.id = 1;
            workProduct01.subject = "Subject";
            workProduct01.description = "Description";
            workProducts.Add(workProduct01);
            editor.SetItem(item, workProducts);
            PfdProcess newItem = editor.GetItem();
            Assert.AreEqual(item, newItem);
        }
    }
}

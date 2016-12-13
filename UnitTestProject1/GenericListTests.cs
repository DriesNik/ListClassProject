using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassProject.Tests
{
    [TestClass()]
    public class GenericListTests
    {
        [TestMethod()]
        public void AddObjectTest()
        {
            GenericList<int> test = new GenericList<int>();
            test.AddObject(5);
            int i = 1;
            Assert.AreEqual(i,test.LongCount());
        }
        [TestMethod()]
        public void AddObjectsTest2()
        {
            GenericList<int> test = new GenericList<int>();
            test.AddObject(-8);
            test.AddObject(4);
            test.AddObject(20);
            test.AddObject(303);
            test.RemoveObject(20);
            int i = 3;
            
            Assert.AreEqual(i,test.Count());
        }
    }
}
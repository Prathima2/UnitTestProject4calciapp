using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary4calciapp;

namespace UnitTestProject4calciapp
{
    [TestClass]
    public class UnitTest1
    {
        Class1 obj = new Class1();
        Class1 obj1 = new Class1();
        [TestMethod]
        public void TestMethod1()
        {
            
            int a = 12;
            int b = 3;
            int actual = obj.add(a, b);
            int expected = 15;
            Assert.AreEqual(expected, actual);
        }
        public void TestMethod2()
        {
            int a = 4;
            int b = 3;
            int actual = obj1.sub(a, b);
            int expected = 1;
            Assert.AreEqual(expected, actual);

        }
        
        public void TestForMultiple(int a, int b)
        {
            int actual = obj.add(a, b);
            int expected = 15;
            Assert.AreEqual(expected, actual);
        }
        public void TestForMultiple1(int a,int b)
        {
            int actual = obj1.sub(a, b);
            int expected = 1;
            Assert.AreEqual(expected, actual);

        }
    }
    }

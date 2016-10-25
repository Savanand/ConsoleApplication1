using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication1;
using ExtensionMethods;using System.Collections.Generic;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAreaOfTriangle()
        {
            double a1 = 7.0;
            double b1= 10.0;
            double c1 = 5.0;
            double expected_area1 = 16.25;

            double a2 = 5.0;
            double b2 = 12.0;
            double c2 = 18.0;
            double expected_area2 = -1.0;

            double a3 = -5.0;
            double b3 = -12.0;
            double c3 = -16.0;
            double expected_area3 = -1.0;



            //assert

            double actual1 =MyExtensions.AreaTriangle(a1, b1, c1);
            Assert.AreEqual(expected_area1, actual1, 0.001, "Area of the triangle is not calculated correctly");

            double actual2 = MyExtensions.AreaTriangle(a2, b2, c2);
            Assert.AreEqual(expected_area2, actual2, "Triangle cant possible tested successfully");

            double actual3 = MyExtensions.AreaTriangle(a3, b3, c3);
            Assert.AreEqual(expected_area3, actual3, "Negative sides are not allowed tested successfully");

        }

        [TestMethod]
        public void TestIsNullOrNotEmpty()
        {
            string str1 = null;
            string str2 = "a";
            string str3 = "";
            string str4 = "null";

            Assert.AreEqual(true, MyExtensions.IsNullOrEmpty(str1)," Null is tested successfully");
            Assert.AreEqual(false, MyExtensions.IsNullOrEmpty(str2), " \"a\" is tested successfully");
            Assert.AreEqual(true, MyExtensions.IsNullOrEmpty(str3), " \"\" is tested successfully");
            Assert.AreEqual(false, MyExtensions.IsNullOrEmpty(str4), " \"Null\" is tested successfully");


        }

        [TestMethod]
        public void TestPositiveFactors()
        {
            List<int> li = new List<int>() { 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, 60 };
            List<int> li2 = new List<int>() { 1, 2, 3, 6, 7, 14, 21, 42};


            CollectionAssert.AreEqual(li, MyExtensions.FindDivisors(60), " 60 factor is tested successfully");
            CollectionAssert.AreEqual(li2, MyExtensions.FindDivisors(42), " 42 factor is tested successfully");

        }

        [TestMethod]
        public void TestFindMostCommon()
        {

            List<int> li = new List<int>() { 5, 4, 3, 2, 4, 5, 1, 6, 1, 2, 5, 4 };
            List<int> li2 = new List<int>() { 1, 2, 3, 4, 5, 1, 6, 7 };
            List<int> li3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

            List<int> res = new List<int>() { 5, 4};
            List<int> res2 = new List<int>() { 1 };
            List<int> res3 = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };


            CollectionAssert.AreEqual(res, MyExtensions.FindMostCommon(li), " Output tested successfully");
            CollectionAssert.AreEqual(res2, MyExtensions.FindMostCommon(li2), "Output tested successfully");
            CollectionAssert.AreEqual(res3, MyExtensions.FindMostCommon(li3), " Output tested successfully");

        }

    }
}

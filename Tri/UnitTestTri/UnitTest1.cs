using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isScaleneTest()
        {
            //Triangle tri = new Triangle(1, 1.5, 3.7); // Test to fail.
            //Assert.IsTrue(tri.isScalene());

            //Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to pass.
            //Assert.IsTrue(tri.isScalene());

            Triangle tri = new Triangle(1.1, 1.1, 1.1); // Test to fail.
            Assert.IsTrue(tri.isScalene());

        }

        [TestMethod]
        public void isEquilateralTest()
        {
            //Triangle tri = new Triangle(1.1, 1.1, 1.1); // Test to pass.
            //Assert.IsTrue(tri.isEquilateral());

            //Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to fail.
            //Assert.IsTrue(tri.isEquilateral());

            Triangle tri = new Triangle(1, 1.5, 3.7); // Test to fail.
            Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to pass.
            Assert.IsTrue(tri.isIsosceles());

            //Triangle tri = new Triangle(1.1, 1.1, 1.1); // Test to fail.
            //Assert.IsTrue(tri.isIsosceles());            

            //Triangle tri = new Triangle(1, 1.5, 3.7); // Test to fail.
            //Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void triNegConstructorTest()
        {
            Triangle tri = new Triangle(-1, -1, -1);

            //Assert.IsTrue(tri.isEquilateral());

            Assert.IsTrue(tri.isScalene());

            //Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void triDoubleConstructorTest()
        {
            Triangle tri = new Triangle(0.0, -2.0, 0.3);

            Assert.IsTrue(tri.isEquilateral());

            //Assert.IsTrue(tri.isScalene());

            //Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void triNullConstructorTest()
        {
            Triangle tri = new Triangle(0.0, 0.0, 0.0);

            //Assert.IsTrue(tri.isEquilateral());

            Assert.IsTrue(tri.isScalene());

            //Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void pointTest()
        {
            Point p = new Point(3, 4);
        }








        //        private int uniqueSides() {
        //  return sides.Distinct<double>().Count();
        //}

        //public bool isScalene() {
        //  if(uniqueSides()==1)
        //    return true;
        //  return false;
        //}

        //public bool isEquilateral() {
        //  if(uniqueSides()==3)
        //    return true;
        //  return false;
        //}

        //public bool isIsosceles() {
        //  if(uniqueSides()==2)
        //    return true;
        //  return false;
    }
}

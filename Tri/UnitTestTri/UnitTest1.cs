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
            Triangle tri = new Triangle(1, 1.5, 3.7); // Test to pass.
            Assert.IsTrue(tri.isScalene());

            //Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to fail.
            //Assert.IsTrue(tri.isScalene());

            //Triangle tri = new Triangle(1.1, 1.1, 1.1); // Test to fail.
            //Assert.IsTrue(tri.isScalene());

        }

        [TestMethod]
        public void isEquilateralTest()
        {
            Triangle tri = new Triangle(1.1, 1.1, 1.1); // Test to pass.
            Assert.IsTrue(tri.isEquilateral());

            //Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to fail.
            //Assert.IsTrue(tri.isEquilateral());

            //Triangle tri = new Triangle(1, 1.5, 3.7); // Test to fail.
            //Assert.IsTrue(tri.isEquilateral());
        }

        [TestMethod]
        public void isIsoscelesTest()
        {
            Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to pass.
            Assert.IsTrue(tri.isIsosceles());

        }
        [TestMethod]
        public void isIsoscelesTestToFail()
        {
            Triangle tri = new Triangle(1, 1.5, 3.7); // Test to fail.
            Assert.IsFalse(tri.isIsosceles());
        }
        [TestMethod]
        public void isEquilateralTestToFail()
        {
            Triangle tri = new Triangle(1.1, 1.3, 1.1); // Test to fail.
            Assert.IsFalse(tri.isEquilateral());
        }
        [TestMethod]
        public void isScaleneTestToFail()
        {
            Triangle tri = new Triangle(1.1, 1.1, 1.1); // Test to fail.
            Assert.IsFalse(tri.isScalene());
        }

        [TestMethod]
        public void triNegConstructorTest()
        {
            Triangle tri = new Triangle(-1, -1, -1);

            Assert.IsTrue(tri.isEquilateral());

            //Assert.IsTrue(tri.isScalene()); // This test passed before making corrections to source code

            //Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void triDoubleConstructorTest()
        {
            Triangle tri = new Triangle(0.0, -2.0, 0.3);

            //Assert.IsTrue(tri.isEquilateral()); // This test passed before making corrections to source code

            Assert.IsTrue(tri.isScalene());

            //Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void triNullConstructorTest()
        {
            Triangle tri = new Triangle(0.0, 0.0, 0.0);

            Assert.IsTrue(tri.isEquilateral()); // Should be nullexception

            //Assert.IsTrue(tri.isScalene()); // This test passed before making corrections to source code

            //Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        public void pointTest()
        {
            Point pA = new Point(0, 0);
            Point pB = new Point(6, 2);
            Point pC = new Point(4, 8);

            Triangle tri = new Triangle(pA, pB, pC);
            Assert.IsTrue(tri.isIsosceles());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void indexExceptionTest()
        {
            {
                
                Triangle tri = new Triangle(-1.1, -1, -1);
                Assert.Fail("Inget undantag kastas!");

            }
        }

        [TestMethod]
        public void pointArrayTest()
        {
            Point pA = new Point(0, 0);
            Point pB = new Point(6, 2);
            Point pC = new Point(4, 8);

            Point[] pointArray = new Point[] { pA, pB, pC };

            Triangle tri = new Triangle(pointArray);
            Assert.IsTrue(tri.isIsosceles()); // Scalene passes, it should be an Isosceles

        }

        [TestMethod]
        public void doubleArrayTest()
        {
            double[] doubleArray = new double[] { 3.3, 3.3, 3.3 };

            Triangle tri = new Triangle(doubleArray);
            Assert.IsTrue(tri.isEquilateral());

        }



    }
}

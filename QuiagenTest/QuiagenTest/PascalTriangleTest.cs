using Algorithms;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiagenTest
{
    public class PascalTriangleTest
    {
        [Test]
        [TestCase(0, 2, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 3, 3)]
        [TestCase(2, 3, 3)]
        [TestCase(3, 3, 1)]
        [TestCase(4, 4, 1)]
        [TestCase(3, 4, 6)]
        [TestCase(5, 4, 1)]

        public void PascalPositiveTest(int c, int r, int result)
        {
            MyAlgorithms myAlgorithms = new MyAlgorithms();

            ClassicAssert.AreEqual(result, myAlgorithms.GetElementFromPascalTriangle(c,r));
        }

        [Test]
        [TestCase(0, 2, 2)]
        [TestCase(1, 2, 3)]
        [TestCase(1, 3, 4)]
        [TestCase(2, 3, 5)]
        [TestCase(3, 3, 6)]
        [TestCase(4, 0, 2)]
        [TestCase(4, 2, 3)]
        [TestCase(5, 4, 4)]

        public void PascalNegativeTest(int c, int r, int result)
        {
            MyAlgorithms myAlgorithms = new MyAlgorithms();

            ClassicAssert.AreNotEqual(result, myAlgorithms.GetElementFromPascalTriangle(c, r));
        }
    }
}

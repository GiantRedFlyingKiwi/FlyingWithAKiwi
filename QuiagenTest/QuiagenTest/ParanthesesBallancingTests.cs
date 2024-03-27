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
    public class ParanthesesBallancingTests
    {
        [Test]
        public void TestBallancingPositive()
        {
            MyAlgorithms ballancing = new MyAlgorithms();
            ClassicAssert.IsTrue(ballancing.CheckParanthesesBalancing("(if (zero? x) max (/ 1 x))"));
        }

        [Test]
        public void TestBallancingPositive2()
        {
            MyAlgorithms ballancing = new MyAlgorithms();
            ClassicAssert.IsTrue(ballancing.CheckParanthesesBalancing("I told him (that it’s not (yet) done). (But he wasn’t listening)"));
        }

        [Test]
        public void TestBallancingPositive3()
        {
            MyAlgorithms ballancing = new MyAlgorithms();
            ClassicAssert.IsTrue(ballancing.CheckParanthesesBalancing("(())((()))()"));
        }

        [Test]
        public void TestBallancingNegative()
        {
            MyAlgorithms ballancing = new MyAlgorithms();
            ClassicAssert.IsFalse(ballancing.CheckParanthesesBalancing(":-)"));
        }

        [Test]
        public void TestBallancingNegative2()
        {
            MyAlgorithms ballancing = new MyAlgorithms();
            ClassicAssert.IsFalse(ballancing.CheckParanthesesBalancing("())("));
        }
        
        [Test]
        public void TestBallancingNegative3()
        {
            MyAlgorithms ballancing = new MyAlgorithms();
            ClassicAssert.IsFalse(ballancing.CheckParanthesesBalancing("("));
        }


    }
}

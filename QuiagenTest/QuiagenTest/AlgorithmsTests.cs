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
    public class AlgorithmsTests
    {
        [Test]
        public void TestBallancingPositive()
        {
            ParanthesesBallancing ballancing = new ParanthesesBallancing();
            ClassicAssert.IsTrue(ballancing.CheckParanthesesBalancing("(if (zero? x) max (/ 1 x))"));
        }

        [Test]
        public void TestBallancingPositive2()
        {
            ParanthesesBallancing ballancing = new ParanthesesBallancing();
            ClassicAssert.IsTrue(ballancing.CheckParanthesesBalancing("I told him (that it’s not (yet) done). (But he wasn’t listening)"));
        }

        [Test]
        public void TestBallancingNegative()
        {
            ParanthesesBallancing ballancing = new ParanthesesBallancing();
            ClassicAssert.IsFalse(ballancing.CheckParanthesesBalancing(":-)"));
        }

        [Test]
        public void TestBallancingNegative2()
        {
            ParanthesesBallancing ballancing = new ParanthesesBallancing();
            ClassicAssert.IsFalse(ballancing.CheckParanthesesBalancing("())("));
        }
    }
}

using System;
using NUnit.Framework;
using Problems.Common.Problems;

namespace HackerRank.Handshake.Test
{
    [TestFixture]
    public class HandshakeProblemTest
    {
        [Test]
        public void Construct_HandshakeProblem()
        {
            //---------------Set up test pack-------------------
            
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var handshakeProblem = new HandshakeProblem("0");
            //---------------Test Result -----------------------
            Assert.IsNotNull(handshakeProblem);
        }

        [Test]
        public void Solve_Given5277_Should13920726()
        {
            //---------------Set up test pack-------------------
            var handshakeProblem = new HandshakeProblem("5277");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = handshakeProblem.Solve();
            //---------------Test Result -----------------------
            Assert.AreEqual("13920726", result);
        }

        [Test]
        public void Solve_Given9302_Should43258951()
        {
            //---------------Set up test pack-------------------
            var handshakeProblem = new HandshakeProblem("9302");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = handshakeProblem.Solve();
            //---------------Test Result -----------------------
            Assert.AreEqual("43258951", result);
        }
    }
}

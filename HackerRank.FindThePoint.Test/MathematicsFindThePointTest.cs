﻿using NUnit.Framework;
using Problems.Common;
using Problems.Common.Problems;

namespace HackerRank.FindThePoint.Test
{
    [TestFixture]
    public class MathematicsFindThePointTest
    {
        [Test]
        public void Construct_MathSolver_ShouldNotBeNull()
        {
            //---------------Set up test pack-------------------
            
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var mathSolver = new MathSolver();
            //---------------Test Result -----------------------
            Assert.IsNotNull(mathSolver);
        }

        [Test]
        public void FindThePointProblem_Given0011_ShouldReturn22()
        {
            //---------------Set up test pack-------------------
            var mathSolver = new MathSolver();
            var findThePointProblem = new FindThePointProblem("0 0 1 1");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = mathSolver.Solve(findThePointProblem);
            //---------------Test Result -----------------------
            Assert.AreEqual("2 2", result);
        }

        [Test]
        public void FindThePointProblem_Given1122_ShouldReturn33()
        {
            //---------------Set up test pack-------------------
            var mathSolver = new MathSolver();
            var findThePointProblem = new FindThePointProblem("1 1 2 2");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = mathSolver.Solve(findThePointProblem);
            //---------------Test Result -----------------------
            Assert.AreEqual("3 3", result);
        }
    }
}

using NUnit.Framework;

namespace HackerRank.MaximumDraws.Test
{
    [TestFixture]
    public class MaximumDrawsTest
    {
        [Test]
        public void Construct_MaximumDrawsProblem()
        {
            //---------------Set up test pack-------------------
            
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var maximumDrawsProblem = new MaximumDrawsProblem("0");
            //---------------Test Result -----------------------
            Assert.IsNotNull(maximumDrawsProblem);
        }

        [Test]
        public void Solve_Given0_ShouldReturn0()
        {
            //---------------Set up test pack-------------------
            var maximumDrawsProblem = new MaximumDrawsProblem("0");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = maximumDrawsProblem.Solve();
            //---------------Test Result -----------------------
            Assert.AreEqual("0", result);
        }

        [Test]
        public void Sovle_Given1_ShouldReturn2()
        {
            //---------------Set up test pack-------------------
            var maximumDrawsProblem = new MaximumDrawsProblem("1");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = maximumDrawsProblem.Solve();
            //---------------Test Result -----------------------
            Assert.AreEqual("2", result);
        }

        [Test]
        public void Sovle_Given2_ShouldReturn3()
        {
            //---------------Set up test pack-------------------
            var maximumDrawsProblem = new MaximumDrawsProblem("2");
            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            var result = maximumDrawsProblem.Solve();
            //---------------Test Result -----------------------
            Assert.AreEqual("3", result);
        }
    }
}

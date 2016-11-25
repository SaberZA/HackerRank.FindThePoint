using System;
using NUnit.Framework;

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

    public class FindThePointProblem : IProblem<string>
    {
        public Point2D Pq { get; set; }
        public Point2D Pp { get; set; }

        public FindThePointProblem(string numberLine)
        {
            var numbers = numberLine.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            Pp = new Point2D(Convert.ToInt32(numbers[0]), Convert.ToInt32(numbers[1]));
            Pq = new Point2D(Convert.ToInt32(numbers[2]), Convert.ToInt32(numbers[3]));
        }

        public string Solve()
        {
            var differenceX = Pq.X - Pp.X;
            var differenceY = Pq.Y - Pp.Y;

            var reflectionPoint = new Point2D(Pq.X + differenceX, Pq.Y + differenceY);

            return string.Format("{0} {1}", reflectionPoint.X, reflectionPoint.Y);
        }
    }

    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public interface IProblem<T>
    {
        T Solve();
    }

    public class MathSolver 
    {
        public T Solve<T>(IProblem<T> problem)
        {
            return problem.Solve();
        }
    }
}

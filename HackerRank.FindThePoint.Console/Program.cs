using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.FindThePoint.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var mathSolver = new MathSolver();
            var lines = Convert.ToInt32(System.Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var numberLine = System.Console.ReadLine();

                var result = mathSolver.Solve(new FindThePointProblem(numberLine));
                System.Console.WriteLine(result);
            }
        }
    }

    public class FindThePointProblem : IProblem<string>
    {
        public Point2D Pq { get; set; }
        public Point2D Pp { get; set; }

        public FindThePointProblem(string numberLine)
        {
            var numbers = numberLine.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
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
